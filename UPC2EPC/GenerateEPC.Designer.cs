namespace UPC2EPC
{
    partial class GenerateEPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImportUPCCButton = new System.Windows.Forms.Button();
            this.ExcelOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.InfoText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filterText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partitionText = new System.Windows.Forms.TextBox();
            this.ProductNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExportXMLCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportCSVCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputPathText = new System.Windows.Forms.TextBox();
            this.IsUseDefaultSetCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputPathLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportUPCCButton
            // 
            this.ImportUPCCButton.Location = new System.Drawing.Point(509, 57);
            this.ImportUPCCButton.Name = "ImportUPCCButton";
            this.ImportUPCCButton.Size = new System.Drawing.Size(126, 50);
            this.ImportUPCCButton.TabIndex = 0;
            this.ImportUPCCButton.Text = "Import UPC File(CSV)";
            this.ImportUPCCButton.UseVisualStyleBackColor = true;
            this.ImportUPCCButton.Click += new System.EventHandler(this.ImportUPCCButton_Click);
            // 
            // ExcelOpenFileDialog
            // 
            this.ExcelOpenFileDialog.FileName = "openFileDialog1";
            // 
            // InfoText
            // 
            this.InfoText.Location = new System.Drawing.Point(25, 320);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(429, 228);
            this.InfoText.TabIndex = 8;
            this.InfoText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter";
            // 
            // filterText
            // 
            this.filterText.Location = new System.Drawing.Point(106, 64);
            this.filterText.Name = "filterText";
            this.filterText.Size = new System.Drawing.Size(100, 20);
            this.filterText.TabIndex = 10;
            this.filterText.TextChanged += new System.EventHandler(this.filterText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Partition";
            // 
            // partitionText
            // 
            this.partitionText.Location = new System.Drawing.Point(106, 103);
            this.partitionText.Name = "partitionText";
            this.partitionText.Size = new System.Drawing.Size(100, 20);
            this.partitionText.TabIndex = 10;
            this.partitionText.TextChanged += new System.EventHandler(this.partitionText_TextChanged);
            // 
            // ProductNameText
            // 
            this.ProductNameText.Location = new System.Drawing.Point(106, 28);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(100, 20);
            this.ProductNameText.TabIndex = 11;
            this.ProductNameText.Text = "Aeroprint";
            this.ProductNameText.TextChanged += new System.EventHandler(this.ProductNameText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product";
            // 
            // ExportXMLCheckBox
            // 
            this.ExportXMLCheckBox.AutoSize = true;
            this.ExportXMLCheckBox.Checked = true;
            this.ExportXMLCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportXMLCheckBox.Location = new System.Drawing.Point(50, 147);
            this.ExportXMLCheckBox.Name = "ExportXMLCheckBox";
            this.ExportXMLCheckBox.Size = new System.Drawing.Size(81, 17);
            this.ExportXMLCheckBox.TabIndex = 12;
            this.ExportXMLCheckBox.Text = "Export XML";
            this.ExportXMLCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportCSVCheckBox
            // 
            this.ExportCSVCheckBox.AutoSize = true;
            this.ExportCSVCheckBox.Location = new System.Drawing.Point(158, 147);
            this.ExportCSVCheckBox.Name = "ExportCSVCheckBox";
            this.ExportCSVCheckBox.Size = new System.Drawing.Size(80, 17);
            this.ExportCSVCheckBox.TabIndex = 12;
            this.ExportCSVCheckBox.Text = "Export CSV";
            this.ExportCSVCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputPathText
            // 
            this.OutputPathText.Enabled = false;
            this.OutputPathText.Location = new System.Drawing.Point(172, 181);
            this.OutputPathText.Multiline = true;
            this.OutputPathText.Name = "OutputPathText";
            this.OutputPathText.Size = new System.Drawing.Size(213, 46);
            this.OutputPathText.TabIndex = 23;
            // 
            // IsUseDefaultSetCheckBox
            // 
            this.IsUseDefaultSetCheckBox.AutoSize = true;
            this.IsUseDefaultSetCheckBox.Checked = true;
            this.IsUseDefaultSetCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsUseDefaultSetCheckBox.Location = new System.Drawing.Point(50, 183);
            this.IsUseDefaultSetCheckBox.Name = "IsUseDefaultSetCheckBox";
            this.IsUseDefaultSetCheckBox.Size = new System.Drawing.Size(116, 17);
            this.IsUseDefaultSetCheckBox.TabIndex = 21;
            this.IsUseDefaultSetCheckBox.Text = "Use Default setting";
            this.IsUseDefaultSetCheckBox.UseVisualStyleBackColor = true;
            this.IsUseDefaultSetCheckBox.CheckedChanged += new System.EventHandler(this.IsUseDefaultSetCheckBox_CheckedChanged);
            // 
            // OutputPathLabel
            // 
            this.OutputPathLabel.AutoSize = true;
            this.OutputPathLabel.Location = new System.Drawing.Point(77, 214);
            this.OutputPathLabel.Name = "OutputPathLabel";
            this.OutputPathLabel.Size = new System.Drawing.Size(71, 13);
            this.OutputPathLabel.TabIndex = 22;
            this.OutputPathLabel.Text = "Output Folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ExportXMLCheckBox);
            this.groupBox1.Controls.Add(this.OutputPathText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IsUseDefaultSetCheckBox);
            this.groupBox1.Controls.Add(this.OutputPathLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ExportCSVCheckBox);
            this.groupBox1.Controls.Add(this.filterText);
            this.groupBox1.Controls.Add(this.partitionText);
            this.groupBox1.Controls.Add(this.ProductNameText);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 258);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "(O)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "(O)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "(M)";
            // 
            // GenerateEPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImportUPCCButton);
            this.Name = "GenerateEPC";
            this.Text = "GenerateEPC";
            this.Load += new System.EventHandler(this.GenerateCSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportUPCCButton;
        private System.Windows.Forms.OpenFileDialog ExcelOpenFileDialog;
        private System.Windows.Forms.RichTextBox InfoText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partitionText;
        private System.Windows.Forms.TextBox ProductNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ExportXMLCheckBox;
        private System.Windows.Forms.CheckBox ExportCSVCheckBox;
        private System.Windows.Forms.TextBox OutputPathText;
        private System.Windows.Forms.CheckBox IsUseDefaultSetCheckBox;
        private System.Windows.Forms.Label OutputPathLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}