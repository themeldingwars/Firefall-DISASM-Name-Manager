using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firefall_DISASM_Name_Manager
{
    public partial class ImportNamesForm : Form
    {
        string ImportedFile = "";
        public ImportNamesForm()
        {
            InitializeComponent();

            ImportSourceComboBox.SelectedIndex = 0;
        }

        private void ImportNamesForm_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkGray;
            this.BackColor = Color.FromArgb(255, 30, 30, 30);
            DarkTheme.ApplyTheme_Dark(this);
        }

        private void ImportSourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImportSourceComboBox.Text.StartsWith("File"))
            {
                ImportSourceFilePathLinkLabel.Visible = true;
                ImportContentTB.ReadOnly = true;
            }
            else
            {
                ImportSourceFilePathLinkLabel.Visible = false;
                ImportContentTB.ReadOnly = false;
                ImportedFile = "";
                ImportSourceFilePathLinkLabel.Text = "<FilePath>";
            }
        }

        private void ImportSourceFilePathLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog
            {
                Title = "Select file to load...",
                Filter = "Python Files (*.py) | *.py|JSON Files (*.json) | *.json"
            };

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(OFD.FileName);
                ImportSourceFilePathLinkLabel.Text = Path.Combine(fileInfo.Directory.Name, fileInfo.Name);
                ImportContentTB.Text = File.ReadAllText(OFD.FileName);
                ImportedFile = OFD.FileName;
            }
        }

        private void ImportContentBtn_Click(object sender, EventArgs e)
        {
            if (ImportContentTB.TextLength == 0)
            {
                MessageBox.Show("No content to import");
                return;
            }

            int LocalBaseAddress = 0x400000;

            if (BaseAddressTB.Text == "")
            {
                if (MessageBox.Show("No Base Address specified. Do you want to reset to the default address 0x400000?", "No Base Address specified", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    BaseAddressTB.Text = "0x400000";
                }
                else
                {
                    return;
                }
            }

            if (BaseAddressTB.Text.StartsWith("0x") && BaseAddressTB.Text.Length > 2 && BaseAddressTB.Text.Length < 11)
            {
                bool IsValid = Int32.TryParse(BaseAddressTB.Text.Substring(2), System.Globalization.NumberStyles.HexNumber, null, out int _LocalBaseAddress);

                if (!IsValid)
                {
                    MessageBox.Show("Base Address is invalid. Please enter a valid address offset in the format 0x########.");
                    return;
                }

                LocalBaseAddress = _LocalBaseAddress;
            }

            List<NameClass> NamesObject = new List<NameClass>();

            switch (ImportSourceComboBox.Text)
            {
                case "File (IDA Python)":
                    NamesObject = new NameManager().FromIDAPython(ImportContentTB.Lines, LocalBaseAddress);
                    break;
                case "File (Ghidra Python)":
                    NamesObject = new NameManager().FromGhidraPython(ImportContentTB.Lines, LocalBaseAddress);
                    break;
                case "File (JSON)":
                    NamesObject = new NameManager().FromJSON(ImportContentTB.Lines, LocalBaseAddress);
                    break;
                case "Raw (IDA Python)":
                    NamesObject = new NameManager().FromIDAPython(ImportContentTB.Lines, LocalBaseAddress);
                    break;
                case "Raw (Ghidra Python)":
                    NamesObject = new NameManager().FromGhidraPython(ImportContentTB.Lines, LocalBaseAddress);
                    break;
                case "Raw (JSON)":
                    NamesObject = new NameManager().FromJSON(ImportContentTB.Lines, LocalBaseAddress);
                    break;
                default:
                    break;
            }

            ((MainForm)Owner).AddNamesToListView(NamesObject);
            this.Close();
        }
    }
}
