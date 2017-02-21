using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace UPC2EPC
{
    public partial class GenerateEPC : Form
    {
        public GenerateEPC()
        {
            InitializeComponent();
        }
        private string productName = "";
        private int header = 48;
        private int filter = 1;
        private int partition = 5;
        private int indicator = 0;
        private string outputFolderPathPrefix = System.Windows.Forms.Application.StartupPath;
        private void ImportUPCCButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please input product Name", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ExportXMLCheckBox.Checked && !ExportCSVCheckBox.Checked)
            {
                MessageBox.Show("Please select export XML or CSV!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.ExcelOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullFileName = ExcelOpenFileDialog.FileName;
                string fileName = fullFileName.Substring(fullFileName.LastIndexOf("\\") + 1);
                fileName = fileName.Substring(0, fileName.LastIndexOf("."));
                InfoText.AppendText("Imported file: " + fileName + Environment.NewLine);
                StreamReader sr = new StreamReader(fullFileName, Encoding.UTF8);
                string lineText;
                int i = 0;
                
                while ((lineText = sr.ReadLine()) != null)
                {
                    i++;

                    if (i == 1)
                    {
                        //the title, ignore it
                        continue;
                    }
                    if (string.IsNullOrWhiteSpace(lineText))
                    {
                        //the line is white space or empty line, just jump to next
                        continue;
                    }
                    string[] segments = lineText.Split(',');
                    
                    string print1 = segments[0];
                    string print2 = segments[1];
                    string print3 = segments[2];
                    string UPC = segments[3];
                    int quantity = int.Parse(segments[4]);
                    string UPCCompanyPrefix = segments[5];
                    string ItemReferenceNumber = segments[6];
                    string transactionNumber = segments[7];
                    string serialNumber = segments[8];
                    string print4 = UPC.Substring(0, 1) + " " + UPC.Substring(1, 5) + " " + UPC.Substring(6, 5) +" "+ UPC.Substring(UPC.Length-1, 1);
                    if (ItemReferenceNumber.Length != 5)
                    {
                        ItemReferenceNumber = UPC.Substring(6, 5);
                    }
                    string EPC = convertToEPC(UPCCompanyPrefix, ItemReferenceNumber, serialNumber);
                    if (String.IsNullOrWhiteSpace(EPC))
                    {
                        MessageBox.Show("EPC length is 0", "Error of EPC", MessageBoxButtons.OK);
                        return;
                    }
                    string outputfileName = productName + "_Job_"+ (i - 1).ToString().PadLeft(2, '0') + "_" + quantity;
                    string folderPath="";
                    string filePath="";
                    
                    print1 = print1.Trim();
                    print2 = print2.Trim();
                    print3 = print3.Trim();

                    //////////////////////////////////////////////////////////////////////////
                    //Export to XML
                    if (ExportXMLCheckBox.Checked)
                    {
                        folderPath = outputFolderPathPrefix + "\\XML";
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        filePath = folderPath + "\\" + outputfileName + ".xml";
                        createAndSaveToXML(filePath, outputfileName, EPC, quantity, print1, print2, print3, print4);
                    }
                    //////////////////////////////////////////////////////////////////////////
                    //Export to CSV
                    if(ExportCSVCheckBox.Checked)
                    {
                        folderPath = outputFolderPathPrefix + "\\CSV";
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        filePath = folderPath + "\\" + outputfileName + ".csv";
                        createAndSaveToCSV(filePath, outputfileName, EPC, quantity, print1, print2, print3, print4);
                    }
                }
                MessageBox.Show("Export successfully!");
            }


        }
        private void writeToFile(string filePath, string text)
        {
            StreamWriter sw = new StreamWriter(filePath, false, Encoding.ASCII);
            sw.Write(text);
            sw.Flush();
            sw.Close();
        }
        private string convertToEPC(string UPCCompanyPrefix, string ItemReferenceNumber, string serialNumber)
        {
            string EPC = "";
            string EPCBin = "";
            string headerBin = Convert.ToString(header, 2);
            headerBin = headerBin.PadLeft(8, '0');
            string filterBin = Convert.ToString(filter, 2);
            filterBin = filterBin.PadLeft(3, '0');
            string partitionBin = Convert.ToString(partition, 2);
            partitionBin = partitionBin.PadLeft(3, '0');
            EPCBin = headerBin + filterBin + partitionBin;
            string GS1CompanyPrefix = Convert.ToString(int.Parse(UPCCompanyPrefix), 2);
            GS1CompanyPrefix = GS1CompanyPrefix.PadLeft(24, '0');
            //GS1CompanyPrefix = "0000" + GS1CompanyPrefix;
            InfoText.AppendText("GS1CompanyPrefix: " + GS1CompanyPrefix + Environment.NewLine);
            InfoText.AppendText("The length of GS1CompanyPrefix: " + GS1CompanyPrefix.Length + Environment.NewLine);
            EPCBin = EPCBin + GS1CompanyPrefix;

            string indicatorBin = Convert.ToString(indicator, 2);
            indicatorBin = indicatorBin.PadLeft(4, '0');

            string ItemReferenceNumberBin = Convert.ToString(int.Parse(ItemReferenceNumber), 2);
            ItemReferenceNumberBin = ItemReferenceNumberBin.PadLeft(16, '0');
            ItemReferenceNumberBin = indicatorBin + ItemReferenceNumberBin;
            InfoText.AppendText("ItemReferenceNumber: " + ItemReferenceNumber + Environment.NewLine);
            InfoText.AppendText("The length of ItemReferenceNumber: " + ItemReferenceNumber.Length + Environment.NewLine);

            EPCBin = EPCBin + ItemReferenceNumberBin;
            string serialNumberBin = Convert.ToString(int.Parse(serialNumber), 2);
            serialNumberBin = serialNumberBin.PadLeft(38, '0');
            EPCBin = EPCBin + serialNumberBin;
            if (EPCBin.Length == 96)
            {
                int theNum = -1;
                int index = -1;
                string theNumBin = "";
                string theNumHex = "";
                for (int i = 0; i < 24; i++)
                {
                    index = i * 4;
                    theNumBin = EPCBin.Substring(index, 4);
                    theNum = Convert.ToInt32(theNumBin, 2);
                    theNumHex = Convert.ToString(theNum, 16);
                    EPC = EPC + theNumHex;
                }
            }
            EPC = EPC.ToUpper();
            InfoText.AppendText("EPC: " + EPC + Environment.NewLine);
            return EPC;
        }

        private void GenerateCSV_Load(object sender, EventArgs e)
        {
            ProductNameText_TextChanged(null, null);
            setOutputFolder();
        }

        private void filterText_TextChanged(object sender, EventArgs e)
        {
            string filterStr = filterText.Text;
            filterStr = filterStr.Trim();
            int result;
            if (!string.IsNullOrEmpty(filterStr))
            {
                if (int.TryParse(filterStr, out result))
                {
                    filter = int.Parse(filterStr);
                    InfoText.AppendText("filter is changed: " + filter + Environment.NewLine);
                }
                else
                {
                    MessageBox.Show("Filter should be number");
                }
                
            }
        }

        private void partitionText_TextChanged(object sender, EventArgs e)
        {
            string partitionStr = partitionText.Text;
            partitionStr = partitionStr.Trim();
            int result;
            if (!string.IsNullOrEmpty(partitionStr))
            {
                if (int.TryParse(partitionStr, out result))
                {
                    partition = int.Parse(partitionStr);
                    InfoText.AppendText("partition is changed: " + partition + Environment.NewLine);
                }
                else
                {
                    MessageBox.Show("Filter should be number");
                }

            }
        }
        private bool checkEPCValided(string toCheck, bool isPart)
        {
            bool result = false;
            if (isPart)
            {
                if (toCheck.Length == 10)
                {
                    result = true;
                }
            }
            else
            {
                if (toCheck.Length == 24)
                {
                    result = true;
                }

            }
            return result;
        }
        private void createAndSaveToXML(string filePath, string outputfileName, string EPC, int quantity, string print0, string print1, string print2, string print3)
        {
            string EPCFront = EPC.Substring(0, 14);
            long index = Convert.ToInt64(EPC.Substring(14), 16);
            string indexStr = "";
            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Indent = true;
            setting.IndentChars = "\t";
            setting.Encoding = Encoding.ASCII;
            using (XmlWriter writer = XmlWriter.Create(filePath, setting))
            {
                writer.WriteStartElement("PLJob");
                writer.WriteAttributeString("JobName", outputfileName);
                writer.WriteAttributeString("JobState", "0");
                writer.WriteAttributeString("Quantity", quantity.ToString());
                writer.WriteAttributeString("Product", productName);
                writer.WriteStartElement("PLTags");
                for (int j = 0; j < quantity; j++)
                {
                    indexStr = Convert.ToString(index, 16);
                    indexStr = indexStr.PadLeft(10, '0');
                    indexStr = indexStr.ToUpper();
                    
                    string newEPC = EPCFront + indexStr;

                    if (!checkEPCValided(indexStr, true) || !checkEPCValided(newEPC, false))
                    {
                        InfoText.AppendText("EPC length is not correct: " + newEPC + Environment.NewLine);
                        MessageBox.Show("EPC length is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    } 
                    writer.WriteStartElement("PLTag");
                    writer.WriteAttributeString("EPC", newEPC);
                    writer.WriteAttributeString("Print0", print0);
                    writer.WriteAttributeString("Print1", print1);
                    writer.WriteAttributeString("Print2", print2);
                    writer.WriteAttributeString("Print3", print3);
                    writer.WriteEndElement();// end element for PLTag
                    index++;
                }
                writer.WriteEndElement();// end element for PLTags
                writer.WriteEndElement();// end element for PLJob
                writer.Flush();
            }
        }
        private void createAndSaveToCSV(string filePath, string outputfileName, string EPC, int quantity, string print0, string print1, string print2, string print3)
        {
            string outputText = "EPC;Print1;Print2;Print3;Print4" + Environment.NewLine;
            string EPCFront = EPC.Substring(0, 14);
            long index = Convert.ToInt64(EPC.Substring(14), 16);
            string indexStr = "";
            for (int j = 0; j < quantity; j++)
            {
                indexStr = Convert.ToString(index, 16);
                indexStr = indexStr.PadLeft(10, '0');
                indexStr = indexStr.ToUpper();
                string newEPC = EPCFront + indexStr;
                if (!checkEPCValided(indexStr, true) || !checkEPCValided(newEPC, false))
                {
                    InfoText.AppendText("EPC length is not correct: " + newEPC + Environment.NewLine);
                    MessageBox.Show("EPC length is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 
                string newLine = newEPC + ";" + print0 +";" + print1 + ";" + print2 + ";" + print3 + ";" + Environment.NewLine;
                index++;
                outputText += newLine;
            }
            writeToFile(filePath, outputText);
        }
        private void ProductNameText_TextChanged(object sender, EventArgs e)
        {
            productName = ProductNameText.Text;
            productName = productName.Trim();
        }

        /// <summary>
        /// set the output path depending on the choice whether using default path
        /// </summary>
        private void setOutputFolder()
        {
            if (!IsUseDefaultSetCheckBox.Checked == true)
            {
                if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    outputFolderPathPrefix = folderBrowserDialog1.SelectedPath;
                    InfoText.AppendText("outputFolderPathPrefix: " + outputFolderPathPrefix + Environment.NewLine);
                }
            }
            

            OutputPathText.Text = outputFolderPathPrefix;
        }

        private void IsUseDefaultSetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setOutputFolder();
        }
    }
}
