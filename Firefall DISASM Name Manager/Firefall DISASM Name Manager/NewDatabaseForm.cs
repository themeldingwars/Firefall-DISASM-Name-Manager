using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firefall_DISASM_Name_Manager
{
    public partial class NewDatabaseForm : Form
    {
        string TITLE = "New Database";
        public string DatabaseFilePath = "";
        public string ClientVersion = "";

        public NewDatabaseForm()
        {
            InitializeComponent();
        }

        private void NewDatabaseForm_Load(object sender, EventArgs e)
        {
            FilePathLabel.Text = "";

            this.ForeColor = Color.DarkGray;
            this.BackColor = Color.FromArgb(255, 30, 30, 30);
            DarkTheme.ApplyTheme_Dark(this);
        }

        private void FilePathBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog
            {
                Title = "Select file to save database as...",
                Filter = "JSON Files (*.json) | *.json",
                FileName = "FF_DISAM_V" + ClientVersionTB.Text
            };

            if (SFD.ShowDialog() == DialogResult.OK)
            {
                DatabaseFilePath = SFD.FileName;
                FilePathLabel.Text = DatabaseFilePath;
                this.Text = $"{TITLE} - {System.IO.Path.GetFileName(SFD.FileName)}";
            }
        }

        private void CreateDatabaseBtn_Click(object sender, EventArgs e)
        {
            if (DatabaseFilePath == "")
            {
                MessageBox.Show("No database file path selected.\n\nPlease select a file path to save the database to.", "No Database File Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClientVersion = ClientVersionTB.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
