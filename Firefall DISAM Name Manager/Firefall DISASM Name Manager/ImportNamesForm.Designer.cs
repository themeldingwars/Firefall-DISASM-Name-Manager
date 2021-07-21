
namespace Firefall_DISASM_Name_Manager
{
    partial class ImportNamesForm
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
            this.ImportLabel = new System.Windows.Forms.Label();
            this.ImportContentGroupBox = new System.Windows.Forms.GroupBox();
            this.ImportContentTB = new System.Windows.Forms.TextBox();
            this.ImportContentBtn = new System.Windows.Forms.Button();
            this.ImportSourceComboBox = new System.Windows.Forms.ComboBox();
            this.ImportSourceFilePathLinkLabel = new System.Windows.Forms.LinkLabel();
            this.BaseAddressTB = new System.Windows.Forms.TextBox();
            this.BaseAddressLabel = new System.Windows.Forms.Label();
            this.ImportContentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportLabel
            // 
            this.ImportLabel.Location = new System.Drawing.Point(204, 12);
            this.ImportLabel.Name = "ImportLabel";
            this.ImportLabel.Size = new System.Drawing.Size(100, 23);
            this.ImportLabel.TabIndex = 2;
            this.ImportLabel.Text = "Import Source :";
            this.ImportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportContentGroupBox
            // 
            this.ImportContentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportContentGroupBox.Controls.Add(this.ImportContentTB);
            this.ImportContentGroupBox.Location = new System.Drawing.Point(12, 41);
            this.ImportContentGroupBox.Name = "ImportContentGroupBox";
            this.ImportContentGroupBox.Size = new System.Drawing.Size(760, 309);
            this.ImportContentGroupBox.TabIndex = 5;
            this.ImportContentGroupBox.TabStop = false;
            this.ImportContentGroupBox.Text = "Import Content";
            // 
            // ImportContentTB
            // 
            this.ImportContentTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImportContentTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportContentTB.Location = new System.Drawing.Point(3, 19);
            this.ImportContentTB.Multiline = true;
            this.ImportContentTB.Name = "ImportContentTB";
            this.ImportContentTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ImportContentTB.Size = new System.Drawing.Size(754, 287);
            this.ImportContentTB.TabIndex = 0;
            this.ImportContentTB.WordWrap = false;
            // 
            // ImportContentBtn
            // 
            this.ImportContentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportContentBtn.Location = new System.Drawing.Point(12, 356);
            this.ImportContentBtn.Name = "ImportContentBtn";
            this.ImportContentBtn.Size = new System.Drawing.Size(760, 23);
            this.ImportContentBtn.TabIndex = 6;
            this.ImportContentBtn.Text = "Import Content";
            this.ImportContentBtn.UseVisualStyleBackColor = true;
            this.ImportContentBtn.Click += new System.EventHandler(this.ImportContentBtn_Click);
            // 
            // ImportSourceComboBox
            // 
            this.ImportSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImportSourceComboBox.FormattingEnabled = true;
            this.ImportSourceComboBox.Items.AddRange(new object[] {
            "File (IDA Python)",
            "File (Ghidra Python)",
            "File (JSON)",
            "Raw (IDA Python)",
            "Raw (Ghidra Python)",
            "Raw (JSON)"});
            this.ImportSourceComboBox.Location = new System.Drawing.Point(310, 12);
            this.ImportSourceComboBox.Name = "ImportSourceComboBox";
            this.ImportSourceComboBox.Size = new System.Drawing.Size(121, 23);
            this.ImportSourceComboBox.TabIndex = 3;
            this.ImportSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.ImportSourceComboBox_SelectedIndexChanged);
            // 
            // ImportSourceFilePathLinkLabel
            // 
            this.ImportSourceFilePathLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportSourceFilePathLinkLabel.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.ImportSourceFilePathLinkLabel.Location = new System.Drawing.Point(437, 12);
            this.ImportSourceFilePathLinkLabel.Name = "ImportSourceFilePathLinkLabel";
            this.ImportSourceFilePathLinkLabel.Size = new System.Drawing.Size(335, 23);
            this.ImportSourceFilePathLinkLabel.TabIndex = 4;
            this.ImportSourceFilePathLinkLabel.TabStop = true;
            this.ImportSourceFilePathLinkLabel.Text = "<FilePath>";
            this.ImportSourceFilePathLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportSourceFilePathLinkLabel.VisitedLinkColor = System.Drawing.Color.DarkTurquoise;
            this.ImportSourceFilePathLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ImportSourceFilePathLinkLabel_LinkClicked);
            // 
            // BaseAddressTB
            // 
            this.BaseAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaseAddressTB.Location = new System.Drawing.Point(118, 12);
            this.BaseAddressTB.MaxLength = 10;
            this.BaseAddressTB.Name = "BaseAddressTB";
            this.BaseAddressTB.Size = new System.Drawing.Size(80, 23);
            this.BaseAddressTB.TabIndex = 1;
            this.BaseAddressTB.Text = "0x400000";
            // 
            // BaseAddressLabel
            // 
            this.BaseAddressLabel.Location = new System.Drawing.Point(12, 12);
            this.BaseAddressLabel.Name = "BaseAddressLabel";
            this.BaseAddressLabel.Size = new System.Drawing.Size(100, 23);
            this.BaseAddressLabel.TabIndex = 0;
            this.BaseAddressLabel.Text = "Base Address :";
            this.BaseAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 391);
            this.Controls.Add(this.BaseAddressTB);
            this.Controls.Add(this.BaseAddressLabel);
            this.Controls.Add(this.ImportSourceFilePathLinkLabel);
            this.Controls.Add(this.ImportSourceComboBox);
            this.Controls.Add(this.ImportContentBtn);
            this.Controls.Add(this.ImportContentGroupBox);
            this.Controls.Add(this.ImportLabel);
            this.Name = "ImportNamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Names";
            this.Load += new System.EventHandler(this.ImportNamesForm_Load);
            this.ImportContentGroupBox.ResumeLayout(false);
            this.ImportContentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImportLabel;
        private System.Windows.Forms.GroupBox ImportContentGroupBox;
        private System.Windows.Forms.TextBox ImportContentTB;
        private System.Windows.Forms.Button ImportContentBtn;
        private System.Windows.Forms.ComboBox ImportSourceComboBox;
        private System.Windows.Forms.LinkLabel ImportSourceFilePathLinkLabel;
        private System.Windows.Forms.TextBox BaseAddressTB;
        private System.Windows.Forms.Label BaseAddressLabel;
    }
}