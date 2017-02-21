using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UPC2EPC
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }
        private int header = 48;
        private int filter = 1;
        private int partition = 5;

        private string UPC;
        private string UPCCompanyPrefix;
        private string ItemReferenceNumber;
        private int indicator = 0;
        private string serialNumber;

        private string convertToEPC()
        {
            string EPC ="";
            string EPCBin="";
            string headerBin = Convert.ToString(header, 2);
            headerBin = headerBin.PadLeft(8, '0');
            string filterBin = Convert.ToString(filter, 2);
            filterBin = filterBin.PadLeft(3,'0');
            string partitionBin = Convert.ToString(partition, 2);
            partitionBin = partitionBin.PadLeft(3,'0');
            EPCBin = headerBin + filterBin + partitionBin;
            string GS1CompanyPrefix = Convert.ToString(int.Parse(UPCCompanyPrefix), 2);
            GS1CompanyPrefix = "0000" + GS1CompanyPrefix;
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
                    index = i*4;
                    theNumBin = EPCBin.Substring(index, 4);
                    theNum = Convert.ToInt32(theNumBin, 2);
                    theNumHex = Convert.ToString(theNum, 16);
                    EPC = EPC + theNumHex;
                }
            }
            EPC = EPC.ToUpper();
            return EPC;
        }
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UPCCompanyPrefix) && !string.IsNullOrEmpty(ItemReferenceNumber) && !string.IsNullOrEmpty(serialNumber))
            {
                EPCText.Text = convertToEPC();
            }
            else
            {
                InfoText.AppendText("UPC or referenceNumber is empty" + Environment.NewLine);
            }
        }

        private void UPCText_TextChanged(object sender, EventArgs e)
        {
            UPC = UPCText.Text;
            UPC = UPC.Trim();
            if (UPC.Length == 12)
            {
                UPCCompanyPrefix = UPC.Substring(0, 6);
                ItemReferenceNumber = UPC.Substring(6, 5);
            }
            else
            {
                InfoText.AppendText("UPC length must be 12" + Environment.NewLine);
            }
        }
        private void RFIDNumberText_TextChanged(object sender, EventArgs e)
        {
            serialNumber = RFIDNumberText.Text;
            serialNumber = serialNumber.Trim();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UPCText_TextChanged(null, null);
            RFIDNumberText_TextChanged(null, null);
        }

        private void IndicatorText_TextChanged(object sender, EventArgs e)
        {
            string indicatorStr = IndicatorText.Text;
            indicatorStr = indicatorStr.Trim();
            int result;
            if (!string.IsNullOrEmpty(indicatorStr))
            {
                if (int.TryParse(indicatorStr,out result))
                {
                    indicator = int.Parse(indicatorStr);
                } 
                else
                {
                }
            }
        }

        
        
    }
}
