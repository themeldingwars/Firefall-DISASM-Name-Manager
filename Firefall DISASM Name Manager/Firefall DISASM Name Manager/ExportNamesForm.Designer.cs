
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
            this.ExportTypeLabel = new System.Windows.Forms.Label();
            this.ExportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ExportContentsTB = new System.Windows.Forms.TextBox();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.EnabledStatusLevelLabel = new System.Windows.Forms.Label();
            this.EnabledStatusLevelComboBox = new System.Windows.Forms.ComboBox();
            this.BaseAddressLabel = new System.Windows.Forms.Label();
            this.BaseAddressTB = new System.Windows.Forms.TextBox();
            this.UpdateBaseAddressBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExportTypeLabel
            // 
            this.ExportTypeLabel.Location = new System.Drawing.Point(12, 12);
            this.ExportTypeLabel.Name = "ExportTypeLabel";
            this.ExportTypeLabel.Size = new System.Drawing.Size(100, 23);
            this.ExportTypeLabel.TabIndex = 0;
            this.ExportTypeLabel.Text = "Export Type :";
            this.ExportTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExportTypeComboBox
            // 
            this.ExportTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExportTypeComboBox.FormattingEnabled = true;
            this.ExportTypeComboBox.Items.AddRange(new object[] {
            "IDA Python",
            "Ghidra Python",
            "JEB Python",
            "JSON",
            "Plain Text"});
            this.ExportTypeComboBox.Location = new System.Drawing.Point(118, 12);
            this.ExportTypeComboBox.Name = "ExportTypeComboBox";
            this.ExportTypeComboBox.Size = new System.Drawing.Size(331, 23);
            this.ExportTypeComboBox.TabIndex = 1;
            this.ExportTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ExportTypeComboBox_SelectedIndexChanged);
            // 
            // ExportContentsTB
            // 
            this.ExportContentsTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportContentsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExportContentsTB.Location = new System.Drawing.Point(12, 99);
            this.ExportContentsTB.MaxLength = 2147483647;
            this.ExportContentsTB.Multiline = true;
            this.ExportContentsTB.Name = "ExportContentsTB";
            this.ExportContentsTB.ReadOnly = true;
            this.ExportContentsTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ExportContentsTB.Size = new System.Drawing.Size(520, 200);
            this.ExportContentsTB.TabIndex = 7;
            this.ExportContentsTB.WordWrap = false;
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFileBtn.Location = new System.Drawing.Point(455, 12);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(77, 81);
            this.SaveFileBtn.TabIndex = 8;
            this.SaveFileBtn.Text = "Save to File";
            this.SaveFileBtn.UseVisualStyleBackColor = true;
            this.SaveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // EnabledStatusLevelLabel
            // 
            this.EnabledStatusLevelLabel.Location = new System.Drawing.Point(12, 41);
            this.EnabledStatusLevelLabel.Name = "EnabledStatusLevelLabel";
            this.EnabledStatusLevelLabel.Size = new System.Drawing.Size(130, 23);
            this.EnabledStatusLevelLabel.TabIndex = 2;
            this.EnabledStatusLevelLabel.Text = "Enabled Status Level :";
            this.EnabledStatusLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnabledStatusLevelComboBox
            // 
            this.EnabledStatusLevelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnabledStatusLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnabledStatusLevelComboBox.FormattingEnabled = true;
            this.EnabledStatusLevelComboBox.Location = new System.Drawing.Point(148, 41);
            this.EnabledStatusLevelComboBox.Name = "EnabledStatusLevelComboBox";
            this.EnabledStatusLevelComboBox.Size = new System.Drawing.Size(301, 23);
            this.EnabledStatusLevelComboBox.TabIndex = 3;
            this.EnabledStatusLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.EnabledStatusLevelComboBox_SelectedIndexChanged);
            // 
            // BaseAddressLabel
            // 
            this.BaseAddressLabel.Location = new System.Drawing.Point(12, 70);
            this.BaseAddressLabel.Name = "BaseAddressLabel";
            this.BaseAddressLabel.Size = new System.Drawing.Size(100, 23);
            this.BaseAddressLabel.TabIndex = 4;
            this.BaseAddressLabel.Text = "Base Address :";
            this.BaseAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseAddressTB
            // 
            this.BaseAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaseAddressTB.Location = new System.Drawing.Point(118, 70);
            this.BaseAddressTB.MaxLength = 10;
            this.BaseAddressTB.Name = "BaseAddressTB";
            this.BaseAddressTB.Size = new System.Drawing.Size(250, 23);
            this.BaseAddressTB.TabIndex = 5;
            this.BaseAddressTB.Text = "0x400000";
            // 
            // UpdateBaseAddressBtn
            // 
            this.UpdateBaseAddressBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBaseAddressBtn.Location = new System.Drawing.Point(374, 69);
            this.UpdateBaseAddressBtn.Name = "UpdateBaseAddressBtn";
            this.UpdateBaseAddressBtn.Size = new System.Drawing.Size(75, 25);
            this.UpdateBaseAddressBtn.TabIndex = 6;
            this.UpdateBaseAddressBtn.Text = "Update";
            this.UpdateBaseAddressBtn.UseVisualStyleBackColor = true;
            this.UpdateBaseAddressBtn.Click += new System.EventHandler(this.UpdateBaseAddressBtn_Click);
            // 
            // ExportNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 311);
            this.Controls.Add(this.UpdateBaseAddressBtn);
            this.Controls.Add(this.BaseAddressTB);
            this.Controls.Add(this.BaseAddressLabel);
            this.Controls.Add(this.EnabledStatusLevelComboBox);
            this.Controls.Add(this.EnabledStatusLevelLabel);
            this.Controls.Add(this.SaveFileBtn);
            this.Controls.Add(this.ExportContentsTB);
            this.Controls.Add(this.ExportTypeComboBox);
            this.Controls.Add(this.ExportTypeLabel);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "ExportNamesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Names";
            this.Load += new System.EventHandler(this.ExportNamesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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