
namespace Firefall_DISASM_Name_Manager
{
    partial class DeduplicationForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "tfApplication",
            "0x6EBA70",
            "tfApplication::Run",
            "0",
            ""}, -1);
            this.DedupeHeaderLabel = new System.Windows.Forms.Label();
            this.DupeAddressListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.DupeAddressLabel = new System.Windows.Forms.Label();
            this.DupeNameLabel = new System.Windows.Forms.Label();
            this.DupeNameListView = new System.Windows.Forms.ListView();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.DeselectAllDuplicatesBtn = new System.Windows.Forms.Button();
            this.SelectAllDuplicatesBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SourceColorPictureBox = new System.Windows.Forms.PictureBox();
            this.NewDupePictureBox = new System.Windows.Forms.PictureBox();
            this.LegendLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SourceColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewDupePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DedupeHeaderLabel
            // 
            this.DedupeHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.DedupeHeaderLabel.Name = "DedupeHeaderLabel";
            this.DedupeHeaderLabel.Size = new System.Drawing.Size(560, 34);
            this.DedupeHeaderLabel.TabIndex = 0;
            this.DedupeHeaderLabel.Text = "Items were detected to exist both in the current database and the items being add" +
    "ed.\r\nPlease select an action to perform to handle the duplicate data.";
            this.DedupeHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DupeAddressListView
            // 
            this.DupeAddressListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DupeAddressListView.CheckBoxes = true;
            this.DupeAddressListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.DupeAddressListView.FullRowSelect = true;
            this.DupeAddressListView.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.DupeAddressListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.DupeAddressListView.Location = new System.Drawing.Point(12, 121);
            this.DupeAddressListView.MultiSelect = false;
            this.DupeAddressListView.Name = "DupeAddressListView";
            this.DupeAddressListView.ShowGroups = false;
            this.DupeAddressListView.Size = new System.Drawing.Size(560, 185);
            this.DupeAddressListView.TabIndex = 2;
            this.DupeAddressListView.UseCompatibleStateImageBehavior = false;
            this.DupeAddressListView.View = System.Windows.Forms.View.Details;
            this.DupeAddressListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.DupeAddressListView_ItemChecked);
            this.DupeAddressListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DupeAddressListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Category";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Status";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "Comment";
            this.columnHeader5.Width = 100;
            // 
            // DupeAddressLabel
            // 
            this.DupeAddressLabel.Location = new System.Drawing.Point(12, 65);
            this.DupeAddressLabel.Name = "DupeAddressLabel";
            this.DupeAddressLabel.Size = new System.Drawing.Size(560, 53);
            this.DupeAddressLabel.TabIndex = 1;
            this.DupeAddressLabel.Text = "The following Item Addresses already exist in the Database.\r\nSelect which ones yo" +
    "u would like to import and overwrite.";
            this.DupeAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DupeNameLabel
            // 
            this.DupeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DupeNameLabel.Location = new System.Drawing.Point(599, 65);
            this.DupeNameLabel.Name = "DupeNameLabel";
            this.DupeNameLabel.Size = new System.Drawing.Size(560, 53);
            this.DupeNameLabel.TabIndex = 3;
            this.DupeNameLabel.Text = "These Items have a conflicting Name with existing items in the Database.\r\nSelect " +
    "the Items below to replace existing Database Items.\r\nAlternatively, you can sele" +
    "ct to Add them anyways.";
            this.DupeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DupeNameListView
            // 
            this.DupeNameListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DupeNameListView.CheckBoxes = true;
            this.DupeNameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.DupeNameListView.FullRowSelect = true;
            this.DupeNameListView.HideSelection = false;
            this.DupeNameListView.Location = new System.Drawing.Point(599, 121);
            this.DupeNameListView.MultiSelect = false;
            this.DupeNameListView.Name = "DupeNameListView";
            this.DupeNameListView.ShowGroups = false;
            this.DupeNameListView.Size = new System.Drawing.Size(560, 154);
            this.DupeNameListView.TabIndex = 4;
            this.DupeNameListView.UseCompatibleStateImageBehavior = false;
            this.DupeNameListView.View = System.Windows.Forms.View.Details;
            this.DupeNameListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.DupeNameListView_ItemChecked);
            this.DupeNameListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DupeNameListView_ItemSelectionChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Name = "columnHeader1";
            this.columnHeader11.Text = "Category";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Name = "columnHeader2";
            this.columnHeader12.Text = "Address";
            this.columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Name = "columnHeader3";
            this.columnHeader13.Text = "Name";
            this.columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Name = "columnHeader4";
            this.columnHeader14.Text = "Status";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Name = "columnHeader5";
            this.columnHeader15.Text = "Comment";
            this.columnHeader15.Width = 100;
            // 
            // DeselectAllDuplicatesBtn
            // 
            this.DeselectAllDuplicatesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeselectAllDuplicatesBtn.Location = new System.Drawing.Point(969, 281);
            this.DeselectAllDuplicatesBtn.Name = "DeselectAllDuplicatesBtn";
            this.DeselectAllDuplicatesBtn.Size = new System.Drawing.Size(190, 25);
            this.DeselectAllDuplicatesBtn.TabIndex = 6;
            this.DeselectAllDuplicatesBtn.Text = "Deselect All Duplicates";
            this.DeselectAllDuplicatesBtn.UseVisualStyleBackColor = true;
            this.DeselectAllDuplicatesBtn.Click += new System.EventHandler(this.DeselectAllDuplicatesBtn_Click);
            // 
            // SelectAllDuplicatesBtn
            // 
            this.SelectAllDuplicatesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAllDuplicatesBtn.Location = new System.Drawing.Point(599, 281);
            this.SelectAllDuplicatesBtn.Name = "SelectAllDuplicatesBtn";
            this.SelectAllDuplicatesBtn.Size = new System.Drawing.Size(190, 25);
            this.SelectAllDuplicatesBtn.TabIndex = 5;
            this.SelectAllDuplicatesBtn.Text = "Select All Duplicates";
            this.SelectAllDuplicatesBtn.UseVisualStyleBackColor = true;
            this.SelectAllDuplicatesBtn.Click += new System.EventHandler(this.SelectAllDuplicatesBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.Location = new System.Drawing.Point(504, 332);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(160, 25);
            this.OkBtn.TabIndex = 7;
            this.OkBtn.Text = "Apply Deduplication";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // SourceColorPictureBox
            // 
            this.SourceColorPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceColorPictureBox.BackColor = System.Drawing.Color.DarkGreen;
            this.SourceColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourceColorPictureBox.Location = new System.Drawing.Point(1141, 15);
            this.SourceColorPictureBox.Name = "SourceColorPictureBox";
            this.SourceColorPictureBox.Size = new System.Drawing.Size(16, 16);
            this.SourceColorPictureBox.TabIndex = 8;
            this.SourceColorPictureBox.TabStop = false;
            // 
            // NewDupePictureBox
            // 
            this.NewDupePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewDupePictureBox.BackColor = System.Drawing.Color.DarkRed;
            this.NewDupePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewDupePictureBox.Location = new System.Drawing.Point(1141, 31);
            this.NewDupePictureBox.Name = "NewDupePictureBox";
            this.NewDupePictureBox.Size = new System.Drawing.Size(16, 16);
            this.NewDupePictureBox.TabIndex = 9;
            this.NewDupePictureBox.TabStop = false;
            // 
            // LegendLabel
            // 
            this.LegendLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LegendLabel.Location = new System.Drawing.Point(943, 12);
            this.LegendLabel.Name = "LegendLabel";
            this.LegendLabel.Size = new System.Drawing.Size(192, 38);
            this.LegendLabel.TabIndex = 10;
            this.LegendLabel.Text = "Current Database Content is Green\r\nNew Duplicate Data is Red";
            this.LegendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeduplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 369);
            this.Controls.Add(this.LegendLabel);
            this.Controls.Add(this.NewDupePictureBox);
            this.Controls.Add(this.SourceColorPictureBox);
            this.Controls.Add(this.DupeNameListView);
            this.Controls.Add(this.DupeAddressListView);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.DeselectAllDuplicatesBtn);
            this.Controls.Add(this.SelectAllDuplicatesBtn);
            this.Controls.Add(this.DupeNameLabel);
            this.Controls.Add(this.DupeAddressLabel);
            this.Controls.Add(this.DedupeHeaderLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeduplicationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Deduplication";
            this.Load += new System.EventHandler(this.DeduplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewDupePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DedupeHeaderLabel;
        private System.Windows.Forms.ListView DupeAddressListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label DupeAddressLabel;
        private System.Windows.Forms.Label DupeNameLabel;
        private System.Windows.Forms.ListView DupeNameListView;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button DeselectAllDuplicatesBtn;
        private System.Windows.Forms.Button SelectAllDuplicatesBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.PictureBox SourceColorPictureBox;
        private System.Windows.Forms.PictureBox NewDupePictureBox;
        private System.Windows.Forms.Label LegendLabel;
    }
}