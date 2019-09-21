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
                        this.stripStatusLabel.Text = "Record added successfully";
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
                    Record old_rc = this.Data[this.tag];
                    this.Set.Add(old_rc);
                    this.Data[this.tag] = rc;
                    ListViewItem item = new ListViewItem(new[] { rc.Fname, rc.Lname, rc.PhNumber });
                    item.Tag = this.tag;
                    this.viewPortListView.Items[this.index]=item;
                    this.ClearFields(this.Controls.OfType<TextBox>());
                    this.stripStatusLabel.Text = "Record modified successfully";
                }
            }
            else
            {
                Console.WriteLine("Application is out of Sync with the data");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(this.index >= 0 && this.tag >= 0 && this.modify && !this.add)
            {
                this.viewPortListView.Items.RemoveAt(this.index);
                Record rc = this.Data[this.tag];
                this.Data.Remove(this.tag);
                this.Set.Remove(rc);
                this.ClearFields(this.Controls.OfType<TextBox>());
                this.stripStatusLabel.Text = "Deleted the Record";
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearFields(this.Controls.OfType<TextBox>());
            this.AddButton.Enabled = false;
            this.stripStatusLabel.Text = "Add Mode";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.WriteToFile();
            this.stripStatusLabel.Text = "Data saved to File";
        }

        private void ViewPortListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = this.viewPortListView.SelectedItems;
            foreach (ListViewItem item in selected)
            {
                int key = (int)this.viewPortListView.SelectedItems[0].Tag;
                PopulateFields(this.Data[key]);
                int index = this.viewPortListView.Items.IndexOf(this.viewPortListView.SelectedItems[0]);
                this.EnableModifyMode(key, index);
                this.stripStatusLabel.Text = "Modify Mode";
                this.AddButton.Enabled = true;
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RebateForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            if (this.EnableAddButton())
            {
                this.AddButton.Enabled = true;
            }
            else
            {
                this.AddButton.Enabled = false;
            }
            
        }

        private void RebateForm_SizeChanged(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                //this.ExpandScreen(c);
            }
            
        }
    }
}