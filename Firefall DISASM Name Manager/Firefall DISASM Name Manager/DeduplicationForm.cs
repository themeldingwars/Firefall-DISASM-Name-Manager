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
    public partial class DeduplicationForm : Form
    {
        Dictionary<string, List<NameClass>> DuplicatesListView;
        Dictionary<string, List<NameClass>> DuplicatesSource;
        bool HasDuplicateAddress = false;
        bool HasDuplicateName = false;
        Dictionary<string, ListViewGroup> AddressGroups = new Dictionary<string, ListViewGroup>();
        Dictionary<string, ListViewGroup> NameGroups = new Dictionary<string, ListViewGroup>();

        public List<NameClass> DeduplicatedItems = new List<NameClass>();

        public DeduplicationForm(Dictionary<string, List<NameClass>> DuplicatesListView, Dictionary<string, List<NameClass>> DuplicatesSource)
        {
            InitializeComponent();

            this.DuplicatesListView = DuplicatesListView;
            this.DuplicatesSource = DuplicatesSource;

            HasDuplicateAddress = DuplicatesListView["Address"].Count > 0;
            HasDuplicateName = DuplicatesListView["Name"].Count > 0;

            DupeAddressListView.Items.Clear();
            DupeNameListView.Items.Clear();
        }

        private ListViewItem BuildItemRow(NameClass item)
        {
            ListViewItem.ListViewSubItem Category = new ListViewItem.ListViewSubItem
            {
                Text = item.Category,
                Name = "Category"
            };
            ListViewItem.ListViewSubItem Address = new ListViewItem.ListViewSubItem
            {
                Text = item.Address,
                Name = "Address"
            };
            ListViewItem.ListViewSubItem Name = new ListViewItem.ListViewSubItem
            {
                Text = item.Name,
                Name = "Name"
            };
            ListViewItem.ListViewSubItem Status = new ListViewItem.ListViewSubItem
            {
                Text = item.Status.ToString(),
                Name = "Status"
            };
            ListViewItem.ListViewSubItem Comment = new ListViewItem.ListViewSubItem
            {
                Text = item.Comment,
                Name = "Comment"
            };

            return new ListViewItem(new ListViewItem.ListViewSubItem[] { Category, Address, Name, Status, Comment }, -1);
        }

        private void DeduplicationForm_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkGray;
            this.BackColor = Color.FromArgb(255, 30, 30, 30);
            DarkTheme.ApplyTheme_Dark(this);

            // Prevent flickering on resize by forcing the ListView to be double buffered
            DupeAddressListView.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(DupeAddressListView, true, null);
            DupeNameListView.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(DupeNameListView, true, null);

            PopulateDuplicateListViews();
        }

        private void PopulateDuplicateListViews()
        {
            // Duplicates list is ideally almost always going to be very small so we can be very inefficient with the item searching to group items together
            foreach (NameClass SourceItem in DuplicatesSource["Address"])
            {
                if (!AddressGroups.ContainsKey(SourceItem.Address))
                {
                    AddressGroups.Add(SourceItem.Address, new ListViewGroup(SourceItem.Address));
                    DupeAddressListView.Groups.Add(AddressGroups.Last().Value);
                }
                ListViewItem SourceListItem = DupeAddressListView.Items.Add(BuildItemRow(SourceItem));
                SourceListItem.Group = AddressGroups[SourceItem.Address];
                SourceListItem.BackColor = Color.DarkGreen;
                SourceListItem.Checked = true;

                foreach (NameClass DupeItem in DuplicatesListView["Address"].Where(x => x.Address == SourceItem.Address))
                {
                    ListViewItem DupeListItem = DupeAddressListView.Items.Add(BuildItemRow(DupeItem));
                    DupeListItem.Group = AddressGroups[DupeItem.Address];
                    DupeListItem.BackColor = Color.DarkRed;
                }
            }

            foreach (NameClass SourceItem in DuplicatesSource["Name"])
            {
                if (!NameGroups.ContainsKey(SourceItem.Name))
                {
                    NameGroups.Add(SourceItem.Name, new ListViewGroup(SourceItem.Name));
                    DupeNameListView.Groups.Add(NameGroups.Last().Value);
                }
                ListViewItem SourceListItem = DupeNameListView.Items.Add(BuildItemRow(SourceItem));
                SourceListItem.Group = NameGroups[SourceItem.Name];
                SourceListItem.BackColor = Color.DarkGreen;
                SourceListItem.Checked = true;

                foreach (NameClass DupeItem in DuplicatesListView["Name"].Where(x => x.Name == SourceItem.Name))
                {
                    ListViewItem DupeListItem = DupeNameListView.Items.Add(BuildItemRow(DupeItem));
                    DupeListItem.Group = NameGroups[DupeItem.Name];
                    DupeListItem.BackColor = Color.DarkRed;
                }
            }
        }

        ListViewItem LastCheckedItem = null;
        private void DupeAddressListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Group != null)
            {
                if (LastCheckedItem != null && LastCheckedItem != e.Item)
                {
                    return;
                }
                LastCheckedItem = e.Item;

                foreach (ListViewItem item in e.Item.Group.Items)
                {
                    if (item != e.Item)
                    {
                        item.Checked = false;
                    }
                }

                LastCheckedItem = null;
            }
        }

        private void DupeAddressListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            e.Item.Selected = false;
        }

        private void DupeNameListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Group != null)
            {
                // Make sure there is always at least one item checked in each group
                foreach (ListViewItem item in e.Item.Group.Items)
                {
                    // If at least one item is checked in the group we're fine
                    if (item.Checked)
                    {
                        return;
                    }
                }

                // No item was checked so force the first item (which should be the Source item) to be checked
                e.Item.Group.Items[0].Checked = true;
            }
        }

        private void DupeNameListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            e.Item.Selected = false;
        }

        private void SelectAllDuplicatesBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in DupeNameListView.Items)
            {
                if (item.BackColor == Color.DarkRed)
                {
                    item.Checked = true;
                }
            }
        }

        private void DeselectAllDuplicatesBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in DupeNameListView.Items)
            {
                if (item.BackColor == Color.DarkRed)
                {
                    item.Checked = false;
                }
            }
        }

        private void ListViewsToNameList()
        {
            foreach (ListViewItem item in DupeAddressListView.CheckedItems)
            {
                NameClass NameObject = new NameClass();
                NameObject.Category = item.SubItems["Category"].Text;
                NameObject.Address = item.SubItems["Address"].Text;
                NameObject.Name = item.SubItems["Name"].Text;
                NameObject.Status = int.Parse(item.SubItems["Status"].Text);
                NameObject.Comment = item.SubItems["Comment"].Text;

                DeduplicatedItems.Add(NameObject);
            }

            foreach (ListViewItem item in DupeNameListView.CheckedItems)
            {
                NameClass NameObject = new NameClass();
                NameObject.Category = item.SubItems["Category"].Text;
                NameObject.Address = item.SubItems["Address"].Text;
                NameObject.Name = item.SubItems["Name"].Text;
                NameObject.Status = int.Parse(item.SubItems["Status"].Text);
                NameObject.Comment = item.SubItems["Comment"].Text;

                DeduplicatedItems.Add(NameObject);
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            ListViewsToNameList();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
