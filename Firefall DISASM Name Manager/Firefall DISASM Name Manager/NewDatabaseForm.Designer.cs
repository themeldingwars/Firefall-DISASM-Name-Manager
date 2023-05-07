
namespace Firefall_DISASM_Name_Manager
{
    partial class NewDatabaseForm
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
            BaseAddressLabel = new System.Windows.Forms.Label();
            BaseAddressTB = new System.Windows.Forms.TextBox();
            ClientVersionTB = new System.Windows.Forms.TextBox();
            ClientVersionLabel = new System.Windows.Forms.Label();
            FilePathBtn = new System.Windows.Forms.Button();
            CreateDatabaseBtn = new System.Windows.Forms.Button();
            CancelBtn = new System.Windows.Forms.Button();
            FilePathLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // BaseAddressLabel
            // 
            BaseAddressLabel.Location = new System.Drawing.Point(187, 12);
            BaseAddressLabel.Name = "BaseAddressLabel";
            BaseAddressLabel.Size = new System.Drawing.Size(100, 23);
            BaseAddressLabel.TabIndex = 0;
            BaseAddressLabel.Text = "Base Address :";
            BaseAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseAddressTB
            // 
            BaseAddressTB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BaseAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            BaseAddressTB.Location = new System.Drawing.Point(393, 12);
            BaseAddressTB.Name = "BaseAddressTB";
            BaseAddressTB.ReadOnly = true;
            BaseAddressTB.Size = new System.Drawing.Size(100, 23);
            BaseAddressTB.TabIndex = 1;
            BaseAddressTB.Text = "0x400000";
            // 
            // ClientVersionTB
            // 
            ClientVersionTB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ClientVersionTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ClientVersionTB.Location = new System.Drawing.Point(393, 41);
            ClientVersionTB.Name = "ClientVersionTB";
            ClientVersionTB.Size = new System.Drawing.Size(100, 23);
            ClientVersionTB.TabIndex = 3;
            ClientVersionTB.Text = "1962";
            // 
            // ClientVersionLabel
            // 
            ClientVersionLabel.Location = new System.Drawing.Point(187, 41);
            ClientVersionLabel.Name = "ClientVersionLabel";
            ClientVersionLabel.Size = new System.Drawing.Size(100, 23);
            ClientVersionLabel.TabIndex = 2;
            ClientVersionLabel.Text = "Client Version :";
            ClientVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilePathBtn
            // 
            FilePathBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            FilePathBtn.Location = new System.Drawing.Point(187, 75);
            FilePathBtn.Name = "FilePathBtn";
            FilePathBtn.Size = new System.Drawing.Size(306, 25);
            FilePathBtn.TabIndex = 4;
            FilePathBtn.Text = "Select Database File Path";
            FilePathBtn.UseVisualStyleBackColor = true;
            FilePathBtn.Click += FilePathBtn_Click;
            // 
            // CreateDatabaseBtn
            // 
            CreateDatabaseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            CreateDatabaseBtn.Location = new System.Drawing.Point(12, 167);
            CreateDatabaseBtn.Name = "CreateDatabaseBtn";
            CreateDatabaseBtn.Size = new System.Drawing.Size(135, 25);
            CreateDatabaseBtn.TabIndex = 6;
            CreateDatabaseBtn.Text = "Create Database";
            CreateDatabaseBtn.UseVisualStyleBackColor = true;
            CreateDatabaseBtn.Click += CreateDatabaseBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CancelBtn.Location = new System.Drawing.Point(533, 167);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new System.Drawing.Size(135, 25);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // FilePathLabel
            // 
            FilePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            FilePathLabel.AutoEllipsis = true;
            FilePathLabel.Location = new System.Drawing.Point(12, 122);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new System.Drawing.Size(656, 23);
            FilePathLabel.TabIndex = 5;
            FilePathLabel.Text = "<FilePath>";
            FilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewDatabaseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new System.Drawing.Size(680, 197);
            Controls.Add(FilePathLabel);
            Controls.Add(CancelBtn);
            Controls.Add(CreateDatabaseBtn);
            Controls.Add(FilePathBtn);
            Controls.Add(ClientVersionTB);
            Controls.Add(ClientVersionLabel);
            Controls.Add(BaseAddressTB);
            Controls.Add(BaseAddressLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewDatabaseForm";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New Database";
            Load += NewDatabaseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label BaseAddressLabel;
        private System.Windows.Forms.TextBox BaseAddressTB;
        private System.Windows.Forms.TextBox ClientVersionTB;
        private System.Windows.Forms.Label ClientVersionLabel;
        private System.Windows.Forms.Button FilePathBtn;
        private System.Windows.Forms.Button CreateDatabaseBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label FilePathLabel;
    }
}