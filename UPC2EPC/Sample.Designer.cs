namespace UPC2EPC
{
    partial class Sample
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UPCText = new System.Windows.Forms.TextBox();
            this.EPCText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RFIDNumberText = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.RichTextBox();
            this.IndicatorText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "EPC";
            // 
            // UPCText
            // 
            this.UPCText.Location = new System.Drawing.Point(92, 115);
            this.UPCText.Name = "UPCText";
            this.UPCText.Size = new System.Drawing.Size(171, 20);
            this.UPCText.TabIndex = 1;
            this.UPCText.Text = "755448440221";
            this.UPCText.TextChanged += new System.EventHandler(this.UPCText_TextChanged);
            // 
            // EPCText
            // 
            this.EPCText.Enabled = false;
            this.EPCText.Location = new System.Drawing.Point(92, 220);
            this.EPCText.Multiline = true;
            this.EPCText.Name = "EPCText";
            this.EPCText.Size = new System.Drawing.Size(491, 100);
            this.EPCText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "RFID Number";
            // 
            // RFIDNumberText
            // 
            this.RFIDNumberText.Location = new System.Drawing.Point(351, 115);
            this.RFIDNumberText.Name = "RFIDNumberText";
            this.RFIDNumberText.Size = new System.Drawing.Size(134, 20);
            this.RFIDNumberText.TabIndex = 1;
            this.RFIDNumberText.Text = "31245621";
            this.RFIDNumberText.TextChanged += new System.EventHandler(this.RFIDNumberText_TextChanged);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(458, 152);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(107, 41);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Info";
            // 
            // InfoText
            // 
            this.InfoText.Location = new System.Drawing.Point(92, 373);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(488, 143);
            this.InfoText.TabIndex = 6;
            this.InfoText.Text = "";
            // 
            // IndicatorText
            // 
            this.IndicatorText.Location = new System.Drawing.Point(161, 24);
            this.IndicatorText.Name = "IndicatorText";
            this.IndicatorText.Size = new System.Drawing.Size(102, 20);
            this.IndicatorText.TabIndex = 7;
            this.IndicatorText.TextChanged += new System.EventHandler(this.IndicatorText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Indicator";
            // 
            // UPC2EPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 551);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IndicatorText);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.EPCText);
            this.Controls.Add(this.RFIDNumberText);
            this.Controls.Add(this.UPCText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UPC2EPC";
            this.Text = "UPC2EPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UPCText;
        private System.Windows.Forms.TextBox EPCText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RFIDNumberText;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox InfoText;
        private System.Windows.Forms.TextBox IndicatorText;
        private System.Windows.Forms.Label label5;
    }
}

