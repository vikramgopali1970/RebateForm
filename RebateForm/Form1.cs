using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebateForm
{
    public partial class RebateForm : Form
    {
        
        private Dictionary<int, Record> Data;
        HashSet<Record> Set;
        Boolean add;
        Boolean modify;
        int tag;
        int index;
        public RebateForm()
        {
            this.Data = new Dictionary<int, Record>();
            this.Set = new HashSet<Record>();
            this.add = true;
            this.modify = false;
            this.tag = -1;
            this.index = -1;
            InitializeComponent();
            LoadFileData();
        }

        
        private void RebateForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Record rc = GetFieldDetails();
            Console.WriteLine(rc.IsValid());
            ArrayList errors = rc.IsValid();
            if(this.add && !this.modify)
            {
                // ADD
                if (errors.Count == 0)
                {
                    int count = this.Data.Count + 1;
                    if (!this.Set.Contains(rc))
                    {
                        this.Data.Add(count, rc);
                        this.Set.Add(rc);
                        this.AddItemToList(rc, count++);
                        this.ClearFields(this.Controls.OfType<TextBox>());
                    }
                    else
                    {
                        errors.Add("Details of this person already exists.");
                    }
                }
                if (errors.Count > 0)
                {
                    Console.WriteLine(errors);
                }
            }
            else if( this.modify && !this.add)
            {
                // MODIFY
                if (!this.Set.Contains(rc))
                {
                    this.Set.Add(rc);
                    this.Data[this.tag] = rc;
                    ListViewItem item = new ListViewItem(new[] { rc.Fname, rc.Lname, rc.PhNumber });
                    item.Tag = this.tag;
                    this.viewPortListView.Items[this.index]=item;
                    this.ClearFields(this.Controls.OfType<TextBox>());
                }
                Console.WriteLine("Here to modify the records");
            }
            else
            {
                Console.WriteLine("Application is out of Sync with the data");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearFields(this.Controls.OfType<TextBox>());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.WriteToFile();
        }

        private void ViewPortListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = this.viewPortListView.SelectedItems;
            foreach (ListViewItem item in selected)
            {
                int key = (int)this.viewPortListView.SelectedItems[0].Tag;
                PopulateFields(this.Data[key]);
                this.tag = key;
                this.index = this.viewPortListView.Items.IndexOf(this.viewPortListView.SelectedItems[0]);
                this.add = false;
                this.modify = true;
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}