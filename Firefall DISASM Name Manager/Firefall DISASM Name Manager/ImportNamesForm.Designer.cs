
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
            ImportLabel = new System.Windows.Forms.Label();
            ImportContentGroupBox = new System.Windows.Forms.GroupBox();
            ImportContentTB = new System.Windows.Forms.TextBox();
            ImportContentBtn = new System.Windows.Forms.Button();
            ImportSourceComboBox = new System.Windows.Forms.ComboBox();
            ImportSourceFilePathLinkLabel = new System.Windows.Forms.LinkLabel();
            BaseAddressTB = new System.Windows.Forms.TextBox();
            BaseAddressLabel = new System.Windows.Forms.Label();
            UpdateDupesCheckBox = new System.Windows.Forms.CheckBox();
            ImportOptionsGroupBox = new System.Windows.Forms.GroupBox();
            ImportContentGroupBox.SuspendLayout();
            ImportOptionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ImportLabel
            // 
            ImportLabel.Location = new System.Drawing.Point(198, 19);
            ImportLabel.Name = "ImportLabel";
            ImportLabel.Size = new System.Drawing.Size(100, 23);
            ImportLabel.TabIndex = 2;
            ImportLabel.Text = "Import Source :";
            ImportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportContentGroupBox
            // 
            ImportContentGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ImportContentGroupBox.Controls.Add(ImportContentTB);
            ImportContentGroupBox.Location = new System.Drawing.Point(12, 98);
            ImportContentGroupBox.Name = "ImportContentGroupBox";
            ImportContentGroupBox.Size = new System.Drawing.Size(910, 307);
            ImportContentGroupBox.TabIndex = 1;
            ImportContentGroupBox.TabStop = false;
            ImportContentGroupBox.Text = "Import Content";
            // 
            // ImportContentTB
            // 
            ImportContentTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ImportContentTB.Dock = System.Windows.Forms.DockStyle.Fill;
            ImportContentTB.Location = new System.Drawing.Point(3, 19);
            ImportContentTB.Multiline = true;
            ImportContentTB.Name = "ImportContentTB";
            ImportContentTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            ImportContentTB.Size = new System.Drawing.Size(904, 285);
            ImportContentTB.TabIndex = 0;
            ImportContentTB.WordWrap = false;
            // 
            // ImportContentBtn
            // 
            ImportContentBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ImportContentBtn.Location = new System.Drawing.Point(12, 411);
            ImportContentBtn.Name = "ImportContentBtn";
            ImportContentBtn.Size = new System.Drawing.Size(910, 25);
            ImportContentBtn.TabIndex = 2;
            ImportContentBtn.Text = "Import Content";
            ImportContentBtn.UseVisualStyleBackColor = true;
            ImportContentBtn.Click += ImportContentBtn_Click;
            // 
            // ImportSourceComboBox
            // 
            ImportSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ImportSourceComboBox.FormattingEnabled = true;
            ImportSourceComboBox.Items.AddRange(new object[] { "File (IDA Python)", "File (IDA Python 7+)", "File (Ghidra Python)", "File (JSON)", "Raw (IDA Python)", "Raw (IDA Python 7+)", "Raw (Ghidra Python)", "Raw (JSON)" });
            ImportSourceComboBox.Location = new System.Drawing.Point(304, 19);
            ImportSourceComboBox.Name = "ImportSourceComboBox";
            ImportSourceComboBox.Size = new System.Drawing.Size(150, 23);
            ImportSourceComboBox.TabIndex = 3;
            ImportSourceComboBox.SelectedIndexChanged += ImportSourceComboBox_SelectedIndexChanged;
            // 
            // ImportSourceFilePathLinkLabel
            // 
            ImportSourceFilePathLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ImportSourceFilePathLinkLabel.LinkColor = System.Drawing.Color.DarkTurquoise;
            ImportSourceFilePathLinkLabel.Location = new System.Drawing.Point(460, 19);
            ImportSourceFilePathLinkLabel.Name = "ImportSourceFilePathLinkLabel";
            ImportSourceFilePathLinkLabel.Size = new System.Drawing.Size(444, 23);
            ImportSourceFilePathLinkLabel.TabIndex = 4;
            ImportSourceFilePathLinkLabel.TabStop = true;
            ImportSourceFilePathLinkLabel.Text = "<FilePath>";
            ImportSourceFilePathLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ImportSourceFilePathLinkLabel.VisitedLinkColor = System.Drawing.Color.DarkTurquoise;
            ImportSourceFilePathLinkLabel.LinkClicked += ImportSourceFilePathLinkLabel_LinkClicked;
            // 
            // BaseAddressTB
            // 
            BaseAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            BaseAddressTB.Location = new System.Drawing.Point(112, 19);
            BaseAddressTB.MaxLength = 10;
            BaseAddressTB.Name = "BaseAddressTB";
            BaseAddressTB.Size = new System.Drawing.Size(80, 23);
            BaseAddressTB.TabIndex = 1;
            BaseAddressTB.Text = "0x400000";
            // 
            // BaseAddressLabel
            // 
            BaseAddressLabel.Location = new System.Drawing.Point(6, 19);
            BaseAddressLabel.Name = "BaseAddressLabel";
            BaseAddressLabel.Size = new System.Drawing.Size(100, 23);
            BaseAddressLabel.TabIndex = 0;
            BaseAddressLabel.Text = "Base Address :";
            BaseAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateDupesCheckBox
            // 
            UpdateDupesCheckBox.Checked = true;
            UpdateDupesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            UpdateDupesCheckBox.Location = new System.Drawing.Point(6, 48);
            UpdateDupesCheckBox.Name = "UpdateDupesCheckBox";
            UpdateDupesCheckBox.Size = new System.Drawing.Size(365, 24);
            UpdateDupesCheckBox.TabIndex = 5;
            UpdateDupesCheckBox.Text = "Update Category, Status, and Comment of Full Duplicate items";
            UpdateDupesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImportOptionsGroupBox
            // 
            ImportOptionsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ImportOptionsGroupBox.Controls.Add(BaseAddressLabel);
            ImportOptionsGroupBox.Controls.Add(UpdateDupesCheckBox);
            ImportOptionsGroupBox.Controls.Add(BaseAddressTB);
            ImportOptionsGroupBox.Controls.Add(ImportSourceFilePathLinkLabel);
            ImportOptionsGroupBox.Controls.Add(ImportLabel);
            ImportOptionsGroupBox.Controls.Add(ImportSourceComboBox);
            ImportOptionsGroupBox.Location = new System.Drawing.Point(12, 12);
            ImportOptionsGroupBox.Name = "ImportOptionsGroupBox";
            ImportOptionsGroupBox.Size = new System.Drawing.Size(910, 80);
            ImportOptionsGroupBox.TabIndex = 0;
            ImportOptionsGroupBox.TabStop = false;
            ImportOptionsGroupBox.Text = "Import Options";
            // 
            // ImportNamesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(934, 446);
            Controls.Add(ImportOptionsGroupBox);
            Controls.Add(ImportContentBtn);
            Controls.Add(ImportContentGroupBox);
            DoubleBuffered = true;
            MinimizeBox = false;
            Name = "ImportNamesForm";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Import Names";
            Load += ImportNamesForm_Load;
            ImportContentGroupBox.ResumeLayout(false);
            ImportContentGroupBox.PerformLayout();
            ImportOptionsGroupBox.ResumeLayout(false);
            ImportOptionsGroupBox.PerformLayout();
            ResumeLayout(false);
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