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
        int backSpace = 0;
        private Dictionary<int, Record> Data;
        HashSet<Record> Set;
        Boolean add;
        Boolean modify;
        int tag;
        int index;
        String startTime = "";
        String endTime = "";
        FileOperations fs;
        public RebateForm()
        {
            this.Data = new Dictionary<int, Record>();
            this.Set = new HashSet<Record>();
            this.add = true;
            this.modify = false;
            this.tag = -1;
            this.index = -1;
            this.fs = new FileOperations();
            InitializeComponent();
            LoadData();
            
        }

        private void LoadData()
        {
            this.Data = this.fs.LoadFileData();
            foreach(int i in this.Data.Keys){
                this.Set.Add(this.Data[i]);
                this.AddItemToList(this.Data[i], i);
            }
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
            Console.WriteLine(rc+" "+errors.Count);
            Console.WriteLine(rc.ZipCode.Length);
            if(this.add && !this.modify)
            {
                // ADD
                if (errors.Count == 0)
                {
                    int count = this.Data.Count + 1;
                    if (!this.Set.Contains(rc))
                    {
                        endTime = DateTime.Now.ToString();
                        rc.FirstCharEntered = Convert.ToDateTime(startTime);
                        rc.SavedRecord = Convert.ToDateTime(endTime);
                        rc.BackSpaceUsed = backSpace;
                        this.Data.Add(count, rc);
                        this.Set.Add(rc);
                        this.AddItemToList(rc, count++);
                        this.ClearFields(this.dataEntryTableLayoutPanel.Controls.OfType<TextBox>());
                        this.stripStatusLabel.Text = "Record added successfully";
                    }
                    else
                    {
                        errors.Add("Details of this person already exists.");
                    }
                }
                if (errors.Count > 0)
                {
                    foreach(String s in errors)
                    {
                        Console.WriteLine(s);
                    }
                    
                }
            }
            else if( this.modify && !this.add)
            {
                // MODIFY
                Record oldRc = this.Data[this.tag];
                if (errors.Count == 0) {
                    this.Set.Remove(oldRc);
                    if (!this.Set.Contains(rc))
                    {
                        this.Set.Add(rc);
                        this.Data[this.tag] = rc;
                        ListViewItem item = new ListViewItem(new[] { rc.Fname, rc.Lname, rc.PhNumber });
                        item.Tag = this.tag;
                        this.viewPortListView.Items[this.index] = item;
                        this.ClearFields(this.dataEntryTableLayoutPanel.Controls.OfType<TextBox>());
                        this.stripStatusLabel.Text = "Record modified successfully";
                    }
                    else
                    {
                        this.Set.Add(oldRc);
                    }
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
                this.ClearFields(this.dataEntryTableLayoutPanel.Controls.OfType<TextBox>());
                this.stripStatusLabel.Text = "Deleted the Record";
            }

        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            this.fs.WriteToFile(this.Data);
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
        private void EnableAdd()
        {
            if (this.EnableAddButton())
            {
                this.AddButton.Enabled = true;
            }
            else
            {
                this.AddButton.Enabled = false;
            }
        }


        private void RebateForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)
            {
                Console.WriteLine("pressed");
                backSpace++;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearFields(this.dataEntryTableLayoutPanel.Controls.OfType<TextBox>());
            this.AddButton.Enabled = false;
            this.stripStatusLabel.Text = "Add Mode";
        }

        private void DateReceivedTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MnameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();
        }

        private void LnameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();
        }

        private void Address_1TextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();
        }

        private void Address_2TextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();
        }

        private void StateTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();
        }

        private void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();
        }

        private void GenderTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();

        }

        private void EmailIdTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();
        }

        private void ProofOfPurchaseTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAdd();
        }

        private void FnameTextBox_TextChanged(object sender, EventArgs e)
        {
            startTime = DateTime.Now.ToString();
            EnableAdd();
        }

        private void PhoneNumberMaskedTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            EnableAdd();
            
        }
    }
}