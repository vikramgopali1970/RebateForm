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

namespace RebateForm
{
    public partial class RebateForm : Form
    {
        private const String datafile = "CS6326Asg2.txt";
        private Dictionary<int, Record> Data;
        HashSet<Record> Set;
        public RebateForm()
        {
            this.Data = new Dictionary<int, Record>();
            this.Set = new HashSet<Record>();
            InitializeComponent();
            Console.WriteLine("Hi");
            CheckOrCreateFile();
            LoadFileData();
        }

        private void WriteToFile()
        {
            String delimiter = "\t";
            using (var writer = new StreamWriter(datafile)) 
            {
                foreach(KeyValuePair<int, Record> item in this.Data)
                {
                    Record rc = item.Value;
                    var line = string.Join(delimiter, rc.ToArray());
                    writer.WriteLine(line);
                }
            }
        }

        private void LoadFileData()
        {
            int count = 0;
            String[] dataVals = File.ReadAllLines(datafile);
            foreach (String data in dataVals)
            {
                Console.WriteLine(data);
                String[] vals = data.Split('\t');
                Console.WriteLine(vals.Length);
                Record rc = new Record(vals[0], vals[1].ToCharArray()[0], vals[2], vals[3], vals[4], vals[5], 
                    vals[6], vals[7], vals[8].ToCharArray()[0], vals[9], vals[10], Boolean.Parse(vals[11]), 
                    Convert.ToDateTime(vals[12]), Convert.ToDateTime(vals[13]),
                    Convert.ToDateTime(vals[14]), Convert.ToInt32(vals[15]));
                this.Data.Add(count, rc);
                this.AddItemToList(rc,count++);
            }
        }

        private void CheckOrCreateFile()
        {
            if (!File.Exists(datafile))
            {
                File.Create(datafile);
            }
        }

        private void PopulateFields(Record rc)
        {
            this.FnameTextBox.Text = rc.Fname;
            this.MnameTextBox.Text = rc.Mname.ToString();
            this.LnameTextBox.Text = rc.Lname;
            this.Address_1TextBox.Text = rc.Address_1;
            this.Address_2TextBox.Text = rc.Address_2;
            this.CityTextBox.Text = rc.City;
            this.StateTextBox.Text = rc.State;
            this.ZipCodeTextBox.Text = rc.ZipCode;
            if (rc.Gender == 'M')
            {
                this.MaleRadioButton.PerformClick();
            }
            else
            {
                this.FemaleRadioButton.PerformClick();
            }
            this.PhoneNumberMaskedTextBox.Text = rc.PhNumber;
            this.EmailIdTextBox.Text = rc.EmailId;
            if (rc.ProofOfPurchraseAttached)
            {
                this.YesRadioButton.PerformClick();
            }
            else
            {
                this.NoRadioButton.PerformClick();
            }
            this.DateReceivedTimePicker.Value = rc.DateReceived;
        }

        private void RebateForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String fname = FnameTextBox.Text.Trim();
            char mname = '-';
            if(MnameTextBox.Text.Length > 0)
            {
                mname = MnameTextBox.Text.ToCharArray()[0];
            }
            String lname = LnameTextBox.Text.Trim();
            String address_1 = Address_1TextBox.Text.Trim();
            String address_2 = Address_2TextBox.Text.Trim();
            String city = CityTextBox.Text.Trim();
            String state = StateTextBox.Text.Trim();
            String zipCode = ZipCodeTextBox.Text.Trim();
            char gender = '-';
            if (MaleRadioButton.Checked)
            {
                gender = 'M';
            }else if (FemaleRadioButton.Checked)
            {
                gender = 'F';
            }
            else
            {
                Console.WriteLine("no gender selected");
            }
            String phNumber = PhoneNumberMaskedTextBox.Text.Trim();
            String email = EmailIdTextBox.Text.Trim();
            bool proofOfPurchraseAttached = true;
            if (YesRadioButton.Checked)
            {
                proofOfPurchraseAttached = true;
            }
            else if (NoRadioButton.Checked)
            {
                proofOfPurchraseAttached = false;
            }
            DateTime dateReceived = DateReceivedTimePicker.Value;
            Record rc = new Record(fname, mname, lname, address_1, address_2, city, state, zipCode, gender, phNumber, email, proofOfPurchraseAttached,
                dateReceived, dateReceived,dateReceived, 0);
            Console.WriteLine(rc.IsValid());
            if (rc.IsValid())
            {
                Console.WriteLine(rc);
                int count = this.Data.Count + 1;
                if (!this.Set.Contains(rc))
                {
                    this.Data.Add(count, rc);
                    this.Set.Add(rc);
                    this.AddItemToList(rc,count++);
                    this.ClearFields(this.Controls.OfType<TextBox>());
                }
            }
        }

        private void ClearFields(IEnumerable<TextBox> elements)
        {
            foreach(TextBox element in elements)
            {
                element.Clear();
            }
        }

        private void AddItemToList(Record rc,int tag)
        {
            ListViewItem  item = new ListViewItem(new[] { rc.Fname, rc.Lname, rc.PhNumber });
            item.Tag = tag;
            this.viewPortListView.Items.Add(item);
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
                Console.WriteLine(this.Data[key]);
                PopulateFields(this.Data[key]);
            }

        }
    }
}