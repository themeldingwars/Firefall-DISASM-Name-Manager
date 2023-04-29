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
    public partial class ExportNamesForm : Form
    {
        List<NameClass> Names;
        int EnabledStatusLevels = 0;
        int LocalBaseAddress = 0x400000;
        string TitleText = "";

        public ExportNamesForm(List<NameClass> NamesObject)
        {
            InitializeComponent();

            TitleText = this.Text;

            LoadStatusValues();

            Names = NamesObject;
            EnabledStatusLevelComboBox.SelectedIndex = 0;

            UpdateLocalBaseAddress();
        }

        private void ExportNamesForm_Load(object sender, EventArgs e)
        {
            SaveFileBtn.Enabled = false;

            this.ForeColor = Color.DarkGray;
            this.BackColor = Color.FromArgb(255, 30, 30, 30);
            DarkTheme.ApplyTheme_Dark(this);
        }

        private void LoadStatusValues()
        {
            foreach (int status in Enum.GetValues(typeof(ENameStatus)))
            {
                EnabledStatusLevelComboBox.Items.Add($"{status}: {Enum.GetName(typeof(ENameStatus), status)}");
            }
        }

        private void ExportTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExportNames();
        }

        private void ExportNames()
        {
            switch (ExportTypeComboBox.Text)
            {
                case "IDA Python":
                    ExportContentsTB.Text = new NameManager().ToIDAPython(Names, EnabledStatusLevels, LocalBaseAddress);
                    break;
                case "IDA Python 7+":
                    ExportContentsTB.Text = new NameManager().ToIDAPython(Names, EnabledStatusLevels, LocalBaseAddress, 7);
                    break;
                case "Ghidra Python":
                    ExportContentsTB.Text = new NameManager().ToGhidraPython(Names, EnabledStatusLevels, LocalBaseAddress);
                    break;
                case "JEB Python":
                    ExportContentsTB.Text = new NameManager().ToJEBPython(Names, EnabledStatusLevels, LocalBaseAddress);
                    break;
                case "JSON":
                    ExportContentsTB.Text = new NameManager().ToJSON(Names, LocalBaseAddress);
                    break;
                case "Plain Text":
                    ExportContentsTB.Text = new NameManager().ToPlainText(Names);
                    break;
                default:
                    break;
            }

            if (ExportTypeComboBox.Text != "")
            {
                SaveFileBtn.Enabled = true;
            }
        }

        private string[] ExportTypeToExtension()
        {
            string[] extension = { "", "" };

            switch (ExportTypeComboBox.Text)
            {
                case "IDA Python":
                case "IDA Python 7+":
                case "Ghidra Python":
                case "JEB Python":
                    extension = new[] { "py", "Python Files (*.py) | *.py" };
                    break;
                case "JSON":
                    extension = new[] { "json", "JSON Files (*.json) | *.json" };
                    break;
                case "Plain Text":
                    extension = new[] { "txt", "Text Files (*.txt) | *.txt" };
                    break;
                default:
                    break;
            }

            return extension;
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            string[] extension = ExportTypeToExtension();

            if (extension[0] == "")
            {
                MessageBox.Show("Selected format does not currently support saving to a file.", "Saving Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SaveFileDialog SFD = new SaveFileDialog
            {
                Title = "Save file as...",
                DefaultExt = extension[0],
                Filter = extension[1]
            };

            // JEB Scripts must have their script filename and entry point method name be identical
            if (ExportTypeComboBox.Text == "JEB Python")
            {
                SFD.FileName = $"JEBScript_FFC_MakeNames_{Globals.TargetClientVersion}.py";
            }

            if (SFD.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(SFD.FileName, ExportContentsTB.Text);
            }
        }

        private void EnabledStatusLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledStatusLevels = int.Parse(EnabledStatusLevelComboBox.Text.Substring(0, EnabledStatusLevelComboBox.Text.IndexOf(':')));
            ExportNames();
        }

        private void UpdateLocalBaseAddress()
        {
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
                    MessageBox.Show("Base Address is invalid. Please enter a valid address offset in the format 0x########.", "Invalid Base Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LocalBaseAddress = _LocalBaseAddress;

                this.Text = TitleText + $" | BaseAddress = {BaseAddressTB.Text}";
            }
        }

        private void UpdateBaseAddressBtn_Click(object sender, EventArgs e)
        {
            UpdateLocalBaseAddress();
            ExportNames();
        }
    }
}
