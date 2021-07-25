
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
            this.UpdateDupesCheckBox = new System.Windows.Forms.CheckBox();
            this.ImportOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ImportContentGroupBox.SuspendLayout();
            this.ImportOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportLabel
            // 
            this.ImportLabel.Location = new System.Drawing.Point(198, 19);
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
            this.ImportContentGroupBox.Location = new System.Drawing.Point(12, 98);
            this.ImportContentGroupBox.Name = "ImportContentGroupBox";
            this.ImportContentGroupBox.Size = new System.Drawing.Size(910, 307);
            this.ImportContentGroupBox.TabIndex = 1;
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
            this.ImportContentTB.Size = new System.Drawing.Size(904, 285);
            this.ImportContentTB.TabIndex = 0;
            this.ImportContentTB.WordWrap = false;
            // 
            // ImportContentBtn
            // 
            this.ImportContentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportContentBtn.Location = new System.Drawing.Point(12, 411);
            this.ImportContentBtn.Name = "ImportContentBtn";
            this.ImportContentBtn.Size = new System.Drawing.Size(910, 25);
            this.ImportContentBtn.TabIndex = 2;
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
            this.ImportSourceComboBox.Location = new System.Drawing.Point(304, 19);
            this.ImportSourceComboBox.Name = "ImportSourceComboBox";
            this.ImportSourceComboBox.Size = new System.Drawing.Size(150, 23);
            this.ImportSourceComboBox.TabIndex = 3;
            this.ImportSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.ImportSourceComboBox_SelectedIndexChanged);
            // 
            // ImportSourceFilePathLinkLabel
            // 
            this.ImportSourceFilePathLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportSourceFilePathLinkLabel.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.ImportSourceFilePathLinkLabel.Location = new System.Drawing.Point(460, 19);
            this.ImportSourceFilePathLinkLabel.Name = "ImportSourceFilePathLinkLabel";
            this.ImportSourceFilePathLinkLabel.Size = new System.Drawing.Size(444, 23);
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
            this.BaseAddressTB.Location = new System.Drawing.Point(112, 19);
            this.BaseAddressTB.MaxLength = 10;
            this.BaseAddressTB.Name = "BaseAddressTB";
            this.BaseAddressTB.Size = new System.Drawing.Size(80, 23);
            this.BaseAddressTB.TabIndex = 1;
            this.BaseAddressTB.Text = "0x400000";
            // 
            // BaseAddressLabel
            // 
            this.BaseAddressLabel.Location = new System.Drawing.Point(6, 19);
            this.BaseAddressLabel.Name = "BaseAddressLabel";
            this.BaseAddressLabel.Size = new System.Drawing.Size(100, 23);
            this.BaseAddressLabel.TabIndex = 0;
            this.BaseAddressLabel.Text = "Base Address :";
            this.BaseAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateDupesCheckBox
            // 
            this.UpdateDupesCheckBox.Checked = true;
            this.UpdateDupesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpdateDupesCheckBox.Location = new System.Drawing.Point(6, 48);
            this.UpdateDupesCheckBox.Name = "UpdateDupesCheckBox";
            this.UpdateDupesCheckBox.Size = new System.Drawing.Size(365, 24);
            this.UpdateDupesCheckBox.TabIndex = 5;
            this.UpdateDupesCheckBox.Text = "Update Category, Status, and Comment of Full Duplicate items";
            this.UpdateDupesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImportOptionsGroupBox
            // 
            this.ImportOptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportOptionsGroupBox.Controls.Add(this.BaseAddressLabel);
            this.ImportOptionsGroupBox.Controls.Add(this.UpdateDupesCheckBox);
            this.ImportOptionsGroupBox.Controls.Add(this.BaseAddressTB);
            this.ImportOptionsGroupBox.Controls.Add(this.ImportSourceFilePathLinkLabel);
            this.ImportOptionsGroupBox.Controls.Add(this.ImportLabel);
            this.ImportOptionsGroupBox.Controls.Add(this.ImportSourceComboBox);
            this.ImportOptionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ImportOptionsGroupBox.Name = "ImportOptionsGroupBox";
            this.ImportOptionsGroupBox.Size = new System.Drawing.Size(910, 80);
            this.ImportOptionsGroupBox.TabIndex = 0;
            this.ImportOptionsGroupBox.TabStop = false;
            this.ImportOptionsGroupBox.Text = "Import Options";
            // 
            // ImportNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 446);
            this.Controls.Add(this.ImportOptionsGroupBox);
            this.Controls.Add(this.ImportContentBtn);
            this.Controls.Add(this.ImportContentGroupBox);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "ImportNamesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Names";
            this.Load += new System.EventHandler(this.ImportNamesForm_Load);
            this.ImportContentGroupBox.ResumeLayout(false);
            this.ImportContentGroupBox.PerformLayout();
            this.ImportOptionsGroupBox.ResumeLayout(false);
            this.ImportOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox UpdateDupesCheckBox;
        private System.Windows.Forms.GroupBox ImportOptionsGroupBox;
    }
}