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

        public DeduplicationForm(Dictionary<string, List<NameClass>> DuplicatesListView, Dictionary<string, List<NameClass>> DuplicatesSource)
        {
            InitializeComponent();

            this.DuplicatesListView = DuplicatesListView;
            this.DuplicatesSource = DuplicatesSource;

            HasDuplicateAddress = DuplicatesListView["Address"].Count > 0;
            HasDuplicateName = DuplicatesListView["Name"].Count > 0;
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
            foreach (NameClass item in DuplicatesListView["Address"])
            {
                listView2.Items.Add(BuildItemRow(item));
            }

            foreach (NameClass item in DuplicatesSource["Address"])
            {
                listView1.Items.Add(BuildItemRow(item));
            }
        }
    }
}
