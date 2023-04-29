
namespace Firefall_DISASM_Name_Manager
{
    partial class ExportNamesForm
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
            ExportTypeLabel = new System.Windows.Forms.Label();
            ExportTypeComboBox = new System.Windows.Forms.ComboBox();
            ExportContentsTB = new System.Windows.Forms.TextBox();
            SaveFileBtn = new System.Windows.Forms.Button();
            EnabledStatusLevelLabel = new System.Windows.Forms.Label();
            EnabledStatusLevelComboBox = new System.Windows.Forms.ComboBox();
            BaseAddressLabel = new System.Windows.Forms.Label();
            BaseAddressTB = new System.Windows.Forms.TextBox();
            UpdateBaseAddressBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ExportTypeLabel
            // 
            ExportTypeLabel.Location = new System.Drawing.Point(12, 12);
            ExportTypeLabel.Name = "ExportTypeLabel";
            ExportTypeLabel.Size = new System.Drawing.Size(100, 23);
            ExportTypeLabel.TabIndex = 0;
            ExportTypeLabel.Text = "Export Type :";
            ExportTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExportTypeComboBox
            // 
            ExportTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ExportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ExportTypeComboBox.FormattingEnabled = true;
            ExportTypeComboBox.Items.AddRange(new object[] { "IDA Python", "IDA Python 7+", "Ghidra Python", "JEB Python", "JSON", "Plain Text" });
            ExportTypeComboBox.Location = new System.Drawing.Point(118, 12);
            ExportTypeComboBox.Name = "ExportTypeComboBox";
            ExportTypeComboBox.Size = new System.Drawing.Size(331, 23);
            ExportTypeComboBox.TabIndex = 1;
            ExportTypeComboBox.SelectedIndexChanged += ExportTypeComboBox_SelectedIndexChanged;
            // 
            // ExportContentsTB
            // 
            ExportContentsTB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ExportContentsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ExportContentsTB.Location = new System.Drawing.Point(12, 99);
            ExportContentsTB.MaxLength = int.MaxValue;
            ExportContentsTB.Multiline = true;
            ExportContentsTB.Name = "ExportContentsTB";
            ExportContentsTB.ReadOnly = true;
            ExportContentsTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            ExportContentsTB.Size = new System.Drawing.Size(520, 200);
            ExportContentsTB.TabIndex = 7;
            ExportContentsTB.WordWrap = false;
            // 
            // SaveFileBtn
            // 
            SaveFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            SaveFileBtn.Location = new System.Drawing.Point(455, 12);
            SaveFileBtn.Name = "SaveFileBtn";
            SaveFileBtn.Size = new System.Drawing.Size(77, 81);
            SaveFileBtn.TabIndex = 8;
            SaveFileBtn.Text = "Save to File";
            SaveFileBtn.UseVisualStyleBackColor = true;
            SaveFileBtn.Click += SaveFileBtn_Click;
            // 
            // EnabledStatusLevelLabel
            // 
            EnabledStatusLevelLabel.Location = new System.Drawing.Point(12, 41);
            EnabledStatusLevelLabel.Name = "EnabledStatusLevelLabel";
            EnabledStatusLevelLabel.Size = new System.Drawing.Size(130, 23);
            EnabledStatusLevelLabel.TabIndex = 2;
            EnabledStatusLevelLabel.Text = "Enabled Status Level :";
            EnabledStatusLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnabledStatusLevelComboBox
            // 
            EnabledStatusLevelComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            EnabledStatusLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            EnabledStatusLevelComboBox.FormattingEnabled = true;
            EnabledStatusLevelComboBox.Location = new System.Drawing.Point(148, 41);
            EnabledStatusLevelComboBox.Name = "EnabledStatusLevelComboBox";
            EnabledStatusLevelComboBox.Size = new System.Drawing.Size(301, 23);
            EnabledStatusLevelComboBox.TabIndex = 3;
            EnabledStatusLevelComboBox.SelectedIndexChanged += EnabledStatusLevelComboBox_SelectedIndexChanged;
            // 
            // BaseAddressLabel
            // 
            BaseAddressLabel.Location = new System.Drawing.Point(12, 70);
            BaseAddressLabel.Name = "BaseAddressLabel";
            BaseAddressLabel.Size = new System.Drawing.Size(100, 23);
            BaseAddressLabel.TabIndex = 4;
            BaseAddressLabel.Text = "Base Address :";
            BaseAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseAddressTB
            // 
            BaseAddressTB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BaseAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            BaseAddressTB.Location = new System.Drawing.Point(118, 70);
            BaseAddressTB.MaxLength = 10;
            BaseAddressTB.Name = "BaseAddressTB";
            BaseAddressTB.Size = new System.Drawing.Size(250, 23);
            BaseAddressTB.TabIndex = 5;
            BaseAddressTB.Text = "0x400000";
            // 
            // UpdateBaseAddressBtn
            // 
            UpdateBaseAddressBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            UpdateBaseAddressBtn.Location = new System.Drawing.Point(374, 69);
            UpdateBaseAddressBtn.Name = "UpdateBaseAddressBtn";
            UpdateBaseAddressBtn.Size = new System.Drawing.Size(75, 25);
            UpdateBaseAddressBtn.TabIndex = 6;
            UpdateBaseAddressBtn.Text = "Update";
            UpdateBaseAddressBtn.UseVisualStyleBackColor = true;
            UpdateBaseAddressBtn.Click += UpdateBaseAddressBtn_Click;
            // 
            // ExportNamesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(544, 311);
            Controls.Add(UpdateBaseAddressBtn);
            Controls.Add(BaseAddressTB);
            Controls.Add(BaseAddressLabel);
            Controls.Add(EnabledStatusLevelComboBox);
            Controls.Add(EnabledStatusLevelLabel);
            Controls.Add(SaveFileBtn);
            Controls.Add(ExportContentsTB);
            Controls.Add(ExportTypeComboBox);
            Controls.Add(ExportTypeLabel);
            DoubleBuffered = true;
            MinimizeBox = false;
            Name = "ExportNamesForm";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Export Names";
            Load += ExportNamesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label ExportTypeLabel;
        private System.Windows.Forms.ComboBox ExportTypeComboBox;
        private System.Windows.Forms.TextBox ExportContentsTB;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.Label EnabledStatusLevelLabel;
        private System.Windows.Forms.ComboBox EnabledStatusLevelComboBox;
        private System.Windows.Forms.Label BaseAddressLabel;
        private System.Windows.Forms.TextBox BaseAddressTB;
        private System.Windows.Forms.Button UpdateBaseAddressBtn;
    }
}