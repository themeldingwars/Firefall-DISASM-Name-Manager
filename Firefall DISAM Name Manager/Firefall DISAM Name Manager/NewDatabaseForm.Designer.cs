
namespace Firefall_DISAM_Name_Manager
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
            this.BaseAddressLabel = new System.Windows.Forms.Label();
            this.BaseAddressTB = new System.Windows.Forms.TextBox();
            this.ClientVersionTB = new System.Windows.Forms.TextBox();
            this.ClientVersionLabel = new System.Windows.Forms.Label();
            this.FilePathBtn = new System.Windows.Forms.Button();
            this.CreateDatabaseBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BaseAddressLabel
            // 
            this.BaseAddressLabel.Location = new System.Drawing.Point(109, 12);
            this.BaseAddressLabel.Name = "BaseAddressLabel";
            this.BaseAddressLabel.Size = new System.Drawing.Size(100, 23);
            this.BaseAddressLabel.TabIndex = 0;
            this.BaseAddressLabel.Text = "Base Address :";
            this.BaseAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseAddressTB
            // 
            this.BaseAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaseAddressTB.Location = new System.Drawing.Point(215, 12);
            this.BaseAddressTB.Name = "BaseAddressTB";
            this.BaseAddressTB.ReadOnly = true;
            this.BaseAddressTB.Size = new System.Drawing.Size(100, 23);
            this.BaseAddressTB.TabIndex = 1;
            this.BaseAddressTB.Text = "0x400000";
            // 
            // ClientVersionTB
            // 
            this.ClientVersionTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientVersionTB.Location = new System.Drawing.Point(215, 41);
            this.ClientVersionTB.Name = "ClientVersionTB";
            this.ClientVersionTB.Size = new System.Drawing.Size(100, 23);
            this.ClientVersionTB.TabIndex = 3;
            this.ClientVersionTB.Text = "1962";
            // 
            // ClientVersionLabel
            // 
            this.ClientVersionLabel.Location = new System.Drawing.Point(109, 41);
            this.ClientVersionLabel.Name = "ClientVersionLabel";
            this.ClientVersionLabel.Size = new System.Drawing.Size(100, 23);
            this.ClientVersionLabel.TabIndex = 2;
            this.ClientVersionLabel.Text = "Client Version :";
            this.ClientVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilePathBtn
            // 
            this.FilePathBtn.Location = new System.Drawing.Point(109, 70);
            this.FilePathBtn.Name = "FilePathBtn";
            this.FilePathBtn.Size = new System.Drawing.Size(206, 23);
            this.FilePathBtn.TabIndex = 4;
            this.FilePathBtn.Text = "Select Database File Path";
            this.FilePathBtn.UseVisualStyleBackColor = true;
            this.FilePathBtn.Click += new System.EventHandler(this.FilePathBtn_Click);
            // 
            // CreateDatabaseBtn
            // 
            this.CreateDatabaseBtn.Location = new System.Drawing.Point(12, 122);
            this.CreateDatabaseBtn.Name = "CreateDatabaseBtn";
            this.CreateDatabaseBtn.Size = new System.Drawing.Size(135, 23);
            this.CreateDatabaseBtn.TabIndex = 6;
            this.CreateDatabaseBtn.Text = "Create Database";
            this.CreateDatabaseBtn.UseVisualStyleBackColor = true;
            this.CreateDatabaseBtn.Click += new System.EventHandler(this.CreateDatabaseBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(278, 122);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(135, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoEllipsis = true;
            this.FilePathLabel.Location = new System.Drawing.Point(12, 96);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(401, 23);
            this.FilePathLabel.TabIndex = 5;
            this.FilePathLabel.Text = "<FilePath>";
            this.FilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 152);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateDatabaseBtn);
            this.Controls.Add(this.FilePathBtn);
            this.Controls.Add(this.ClientVersionTB);
            this.Controls.Add(this.ClientVersionLabel);
            this.Controls.Add(this.BaseAddressTB);
            this.Controls.Add(this.BaseAddressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Database";
            this.Load += new System.EventHandler(this.NewDatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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