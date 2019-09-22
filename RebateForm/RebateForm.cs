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
        
        protected Dictionary<int, Record> Data;
        HashSet<Record> Set;
        Boolean add;
        Boolean modify;
        int tag;
        int index;

        internal Dictionary<int, Record> Data1 { get => Data; set => Data = value; }
        internal HashSet<Record> Set1 { get => Set; set => Set = value; }
        public bool Add { get => add; set => add = value; }
        public bool Modify { get => modify; set => modify = value; }

        public RebateForm()
        {
            this.Data1 = new Dictionary<int, Record>();
            this.Set1 = new HashSet<Record>();
            this.Add = true;
            this.Modify = false;
            this.tag = -1;
            this.index = -1;
            InitializeComponent();
            LoadFileData();
        }

        
        private void RebateForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1280;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 800f;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);

            foreach (Control control in this.Controls)
            {
                Point pt = control.Location;
                pt.Y += (int)heightRatio;
                control.Location = pt;
                control.Font = new Font("Verdana", control.Font.SizeInPoints * heightRatio * widthRatio);
            }
            this.CenterToScreen();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Record rc = GetFieldDetails();
            ArrayList errors = rc.IsValid();
            if(this.Add && !this.Modify)
            {
                // ADD
                if (errors.Count == 0)
                {
                    int count = this.Data1.Count + 1;
                    if (!this.Set1.Contains(rc))
                    {
                        this.Data1.Add(count, rc);
                        this.Set1.Add(rc);
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
            else if( this.Modify && !this.Add)
            {
                // MODIFY
                if (!this.Set1.Contains(rc))
                {
                    this.Set1.Add(rc);
                    Record old_rc = this.Data1[this.tag];
                    this.Set1.Add(old_rc);
                    this.Data1[this.tag] = rc;
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
            if(this.index >= 0 && this.tag >= 0 && this.Modify && !this.Add)
            {
                this.viewPortListView.Items.RemoveAt(this.index);
                Record rc = this.Data1[this.tag];
                this.Data1.Remove(this.tag);
                this.Set1.Remove(rc);
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
            WriteToFile();
            this.stripStatusLabel.Text = "Data saved to File";
        }

        private void ViewPortListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = this.viewPortListView.SelectedItems;
            foreach (ListViewItem item in selected)
            {
                int key = (int)this.viewPortListView.SelectedItems[0].Tag;
                PopulateFields(this.Data1[key]);
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
    }
}