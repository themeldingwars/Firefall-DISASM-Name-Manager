
namespace Firefall_DISASM_Name_Manager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Application",
            "0x6EBA70",
            "tfApplication::Run",
            "0",
            "Run Subroutine"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "D3DRenderer",
            "0x1308500",
            "d3drenderer::Initialize",
            "0",
            "D3D Renderer Initialize function"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "fsDataPaths",
            "0x16B84F0",
            "fsDataPaths::FileExists",
            "0",
            "May be part of slFileSystem instead of fsDataPaths"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "slini",
            "0x16DD290",
            "slini::GetStringWithResult",
            "1",
            "Unclear if tfSettings, or slini, or slParser. (SectionName, VariableName, Found);" +
                " Found is set to 1 if value is found, 0 if using default"}, -1);
            this.NamesListView = new System.Windows.Forms.ListView();
            this.CategoryColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.AddressColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.NameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.StatusColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.CommentColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.NamesListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopySelectedItemBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.NamesListContextMenuStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteSelectedItemBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.BaseAddressTB = new System.Windows.Forms.TextBox();
            this.BaseAddressLabel = new System.Windows.Forms.Label();
            this.SubmitNameBtn = new System.Windows.Forms.Button();
            this.CommentTB = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.EditModeBtn = new System.Windows.Forms.Button();
            this.AddModeBtn = new System.Windows.Forms.Button();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.DatabaseMenuStripBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDatabaseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseMenuStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadDatabaseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDatabaseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportNamesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportNamesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeSplitContainer = new System.Windows.Forms.SplitContainer();
            this.NamesListContextMenuStrip.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModeSplitContainer)).BeginInit();
            this.ModeSplitContainer.Panel1.SuspendLayout();
            this.ModeSplitContainer.Panel2.SuspendLayout();
            this.ModeSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // NamesListView
            // 
            this.NamesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NamesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CategoryColumnHeader,
            this.AddressColumnHeader,
            this.NameColumnHeader,
            this.StatusColumnHeader,
            this.CommentColumnHeader});
            this.NamesListView.ContextMenuStrip = this.NamesListContextMenuStrip;
            this.NamesListView.FullRowSelect = true;
            this.NamesListView.HideSelection = false;
            this.NamesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.NamesListView.Location = new System.Drawing.Point(12, 27);
            this.NamesListView.MultiSelect = false;
            this.NamesListView.Name = "NamesListView";
            this.NamesListView.Size = new System.Drawing.Size(960, 255);
            this.NamesListView.TabIndex = 1;
            this.NamesListView.UseCompatibleStateImageBehavior = false;
            this.NamesListView.View = System.Windows.Forms.View.Details;
            this.NamesListView.SelectedIndexChanged += new System.EventHandler(this.NamesListView_SelectedIndexChanged);
            // 
            // CategoryColumnHeader
            // 
            this.CategoryColumnHeader.Name = "CategoryColumnHeader";
            this.CategoryColumnHeader.Text = "Category";
            this.CategoryColumnHeader.Width = 120;
            // 
            // AddressColumnHeader
            // 
            this.AddressColumnHeader.Name = "AddressColumnHeader";
            this.AddressColumnHeader.Text = "Address";
            this.AddressColumnHeader.Width = 90;
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Name = "NameColumnHeader";
            this.NameColumnHeader.Text = "Name";
            this.NameColumnHeader.Width = 340;
            // 
            // StatusColumnHeader
            // 
            this.StatusColumnHeader.Name = "StatusColumnHeader";
            this.StatusColumnHeader.Text = "Status";
            // 
            // CommentColumnHeader
            // 
            this.CommentColumnHeader.Name = "CommentColumnHeader";
            this.CommentColumnHeader.Text = "Comment";
            this.CommentColumnHeader.Width = 340;
            // 
            // NamesListContextMenuStrip
            // 
            this.NamesListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopySelectedItemBtn,
            this.NamesListContextMenuStripSeparator1,
            this.DeleteSelectedItemBtn});
            this.NamesListContextMenuStrip.Name = "NamesListContextMenuStrip";
            this.NamesListContextMenuStrip.Size = new System.Drawing.Size(108, 54);
            this.NamesListContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.NamesListContextMenuStrip_Opening);
            // 
            // CopySelectedItemBtn
            // 
            this.CopySelectedItemBtn.Name = "CopySelectedItemBtn";
            this.CopySelectedItemBtn.Size = new System.Drawing.Size(107, 22);
            this.CopySelectedItemBtn.Text = "Copy";
            this.CopySelectedItemBtn.Click += new System.EventHandler(this.CopySelectedItemBtn_Click);
            // 
            // NamesListContextMenuStripSeparator1
            // 
            this.NamesListContextMenuStripSeparator1.Name = "NamesListContextMenuStripSeparator1";
            this.NamesListContextMenuStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // DeleteSelectedItemBtn
            // 
            this.DeleteSelectedItemBtn.Name = "DeleteSelectedItemBtn";
            this.DeleteSelectedItemBtn.Size = new System.Drawing.Size(107, 22);
            this.DeleteSelectedItemBtn.Text = "Delete";
            this.DeleteSelectedItemBtn.Click += new System.EventHandler(this.DeleteSelectedItemBtn_Click);
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.NameGroupBox.Controls.Add(this.BaseAddressTB);
            this.NameGroupBox.Controls.Add(this.BaseAddressLabel);
            this.NameGroupBox.Controls.Add(this.SubmitNameBtn);
            this.NameGroupBox.Controls.Add(this.CommentTB);
            this.NameGroupBox.Controls.Add(this.CommentLabel);
            this.NameGroupBox.Controls.Add(this.StatusComboBox);
            this.NameGroupBox.Controls.Add(this.StatusLabel);
            this.NameGroupBox.Controls.Add(this.NameTB);
            this.NameGroupBox.Controls.Add(this.NameLabel);
            this.NameGroupBox.Controls.Add(this.AddressTB);
            this.NameGroupBox.Controls.Add(this.AddressLabel);
            this.NameGroupBox.Controls.Add(this.CategoryComboBox);
            this.NameGroupBox.Controls.Add(this.CategoryLabel);
            this.NameGroupBox.Location = new System.Drawing.Point(12, 317);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Size = new System.Drawing.Size(960, 152);
            this.NameGroupBox.TabIndex = 3;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // BaseAddressTB
            // 
            this.BaseAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaseAddressTB.Location = new System.Drawing.Point(580, 80);
            this.BaseAddressTB.MaxLength = 10;
            this.BaseAddressTB.Name = "BaseAddressTB";
            this.BaseAddressTB.Size = new System.Drawing.Size(374, 23);
            this.BaseAddressTB.TabIndex = 11;
            this.BaseAddressTB.Text = "0x400000";
            // 
            // BaseAddressLabel
            // 
            this.BaseAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseAddressLabel.Location = new System.Drawing.Point(484, 80);
            this.BaseAddressLabel.Name = "BaseAddressLabel";
            this.BaseAddressLabel.Size = new System.Drawing.Size(90, 23);
            this.BaseAddressLabel.TabIndex = 10;
            this.BaseAddressLabel.Text = "Base Address :";
            this.BaseAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubmitNameBtn
            // 
            this.SubmitNameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitNameBtn.Location = new System.Drawing.Point(580, 109);
            this.SubmitNameBtn.Name = "SubmitNameBtn";
            this.SubmitNameBtn.Size = new System.Drawing.Size(374, 25);
            this.SubmitNameBtn.TabIndex = 12;
            this.SubmitNameBtn.Text = "Add New Name";
            this.SubmitNameBtn.UseVisualStyleBackColor = true;
            this.SubmitNameBtn.Click += new System.EventHandler(this.SubmitNameBtn_Click);
            // 
            // CommentTB
            // 
            this.CommentTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentTB.Location = new System.Drawing.Point(580, 22);
            this.CommentTB.Multiline = true;
            this.CommentTB.Name = "CommentTB";
            this.CommentTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CommentTB.Size = new System.Drawing.Size(373, 52);
            this.CommentTB.TabIndex = 9;
            this.CommentTB.WordWrap = false;
            this.CommentTB.TextChanged += new System.EventHandler(this.CommentTB_TextChanged);
            // 
            // CommentLabel
            // 
            this.CommentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentLabel.Location = new System.Drawing.Point(484, 22);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(90, 23);
            this.CommentLabel.TabIndex = 8;
            this.CommentLabel.Text = "Comment :";
            this.CommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(88, 109);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(359, 23);
            this.StatusComboBox.TabIndex = 7;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(7, 109);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(75, 23);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status :";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTB
            // 
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTB.Location = new System.Drawing.Point(88, 80);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(359, 23);
            this.NameTB.TabIndex = 5;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(7, 80);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 23);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name :";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressTB
            // 
            this.AddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTB.Location = new System.Drawing.Point(88, 51);
            this.AddressTB.MaxLength = 10;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(359, 23);
            this.AddressTB.TabIndex = 3;
            this.AddressTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressTB_KeyDown);
            this.AddressTB.Leave += new System.EventHandler(this.AddressTB_Leave);
            // 
            // AddressLabel
            // 
            this.AddressLabel.Location = new System.Drawing.Point(7, 51);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(75, 23);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address :";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(88, 22);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(359, 23);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.TextChanged += new System.EventHandler(this.CategoryComboBox_TextChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Location = new System.Drawing.Point(7, 22);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(75, 23);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category :";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditModeBtn
            // 
            this.EditModeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditModeBtn.Location = new System.Drawing.Point(0, 0);
            this.EditModeBtn.Name = "EditModeBtn";
            this.EditModeBtn.Size = new System.Drawing.Size(480, 25);
            this.EditModeBtn.TabIndex = 0;
            this.EditModeBtn.Text = "Edit Mode";
            this.EditModeBtn.UseVisualStyleBackColor = true;
            this.EditModeBtn.Click += new System.EventHandler(this.EditModeBtn_Click);
            // 
            // AddModeBtn
            // 
            this.AddModeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddModeBtn.Location = new System.Drawing.Point(0, 0);
            this.AddModeBtn.Name = "AddModeBtn";
            this.AddModeBtn.Size = new System.Drawing.Size(476, 25);
            this.AddModeBtn.TabIndex = 1;
            this.AddModeBtn.Text = "Add Mode";
            this.AddModeBtn.UseVisualStyleBackColor = true;
            this.AddModeBtn.Click += new System.EventHandler(this.AddModeBtn_Click);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatabaseMenuStripBtn,
            this.ImportNamesBtn,
            this.ExportNamesBtn});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(984, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            // 
            // DatabaseMenuStripBtn
            // 
            this.DatabaseMenuStripBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDatabaseBtn,
            this.DatabaseMenuStripSeparator1,
            this.LoadDatabaseBtn,
            this.SaveDatabaseBtn});
            this.DatabaseMenuStripBtn.Name = "DatabaseMenuStripBtn";
            this.DatabaseMenuStripBtn.Size = new System.Drawing.Size(67, 20);
            this.DatabaseMenuStripBtn.Text = "Database";
            // 
            // NewDatabaseBtn
            // 
            this.NewDatabaseBtn.Name = "NewDatabaseBtn";
            this.NewDatabaseBtn.Size = new System.Drawing.Size(151, 22);
            this.NewDatabaseBtn.Text = "New Database";
            this.NewDatabaseBtn.Click += new System.EventHandler(this.NewDatabaseBtn_Click);
            // 
            // DatabaseMenuStripSeparator1
            // 
            this.DatabaseMenuStripSeparator1.Name = "DatabaseMenuStripSeparator1";
            this.DatabaseMenuStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // LoadDatabaseBtn
            // 
            this.LoadDatabaseBtn.Name = "LoadDatabaseBtn";
            this.LoadDatabaseBtn.Size = new System.Drawing.Size(151, 22);
            this.LoadDatabaseBtn.Text = "Load Database";
            this.LoadDatabaseBtn.Click += new System.EventHandler(this.LoadDatabaseBtn_Click);
            // 
            // SaveDatabaseBtn
            // 
            this.SaveDatabaseBtn.Name = "SaveDatabaseBtn";
            this.SaveDatabaseBtn.Size = new System.Drawing.Size(151, 22);
            this.SaveDatabaseBtn.Text = "Save Database";
            this.SaveDatabaseBtn.Click += new System.EventHandler(this.SaveDatabaseBtn_Click);
            // 
            // ImportNamesBtn
            // 
            this.ImportNamesBtn.Name = "ImportNamesBtn";
            this.ImportNamesBtn.Size = new System.Drawing.Size(95, 20);
            this.ImportNamesBtn.Text = "Import Names";
            this.ImportNamesBtn.Click += new System.EventHandler(this.ImportNamesBtn_Click);
            // 
            // ExportNamesBtn
            // 
            this.ExportNamesBtn.Name = "ExportNamesBtn";
            this.ExportNamesBtn.Size = new System.Drawing.Size(93, 20);
            this.ExportNamesBtn.Text = "Export Names";
            this.ExportNamesBtn.Click += new System.EventHandler(this.ExportNamesBtn_Click);
            // 
            // ModeSplitContainer
            // 
            this.ModeSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ModeSplitContainer.IsSplitterFixed = true;
            this.ModeSplitContainer.Location = new System.Drawing.Point(12, 288);
            this.ModeSplitContainer.Name = "ModeSplitContainer";
            // 
            // ModeSplitContainer.Panel1
            // 
            this.ModeSplitContainer.Panel1.Controls.Add(this.EditModeBtn);
            // 
            // ModeSplitContainer.Panel2
            // 
            this.ModeSplitContainer.Panel2.Controls.Add(this.AddModeBtn);
            this.ModeSplitContainer.Size = new System.Drawing.Size(960, 25);
            this.ModeSplitContainer.SplitterDistance = 480;
            this.ModeSplitContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 477);
            this.Controls.Add(this.ModeSplitContainer);
            this.Controls.Add(this.NameGroupBox);
            this.Controls.Add(this.NamesListView);
            this.Controls.Add(this.MainFormMenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firefall DISASM Name Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NamesListContextMenuStrip.ResumeLayout(false);
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ModeSplitContainer.Panel1.ResumeLayout(false);
            this.ModeSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModeSplitContainer)).EndInit();
            this.ModeSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView NamesListView;
        private System.Windows.Forms.ColumnHeader CategoryColumnHeader;
        private System.Windows.Forms.ColumnHeader AddressColumnHeader;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader StatusColumnHeader;
        private System.Windows.Forms.ColumnHeader CommentColumnHeader;
        private System.Windows.Forms.GroupBox NameGroupBox;
        private System.Windows.Forms.TextBox CommentTB;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button EditModeBtn;
        private System.Windows.Forms.Button AddModeBtn;
        private System.Windows.Forms.Button SubmitNameBtn;
        private System.Windows.Forms.ToolStripMenuItem ImportNamesBtn;
        private System.Windows.Forms.ToolStripMenuItem ExportNamesBtn;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DatabaseMenuStripBtn;
        private System.Windows.Forms.ToolStripMenuItem NewDatabaseBtn;
        private System.Windows.Forms.ToolStripSeparator DatabaseMenuStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LoadDatabaseBtn;
        private System.Windows.Forms.ToolStripMenuItem SaveDatabaseBtn;
        private System.Windows.Forms.SplitContainer ModeSplitContainer;
        private System.Windows.Forms.TextBox BaseAddressTB;
        private System.Windows.Forms.Label BaseAddressLabel;
        private System.Windows.Forms.ContextMenuStrip NamesListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopySelectedItemBtn;
        private System.Windows.Forms.ToolStripSeparator NamesListContextMenuStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeleteSelectedItemBtn;
    }
}

