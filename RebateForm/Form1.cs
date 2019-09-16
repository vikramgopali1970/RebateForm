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
        private Dictionary<int, Record> data;
        HashSet<Record> set;
        public RebateForm()
        {
            this.data = new Dictionary<int, Record>();
            this.set = new HashSet<Record>();
            InitializeComponent();
            Console.WriteLine("Hi");
            CheckOrCreateFile();
            LoadFileData();
        }

        private void WriteToFile()
        {

        }

        private void LoadFileData()
        {
            Console.WriteLine("here to load the data from file");
        }

        private void CheckOrCreateFile()
        {
            if (!File.Exists(datafile))
            {
                File.Create(datafile);
            }
        }

        private void RebateForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String fname = FnameTextBox.Text.Trim();
            Nullable<char> mname = null;
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
            Nullable<char> gender = null;
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
            Nullable<bool> proofOfPurchraseAttached = null;
            if (YesRadioButton.Checked)
            {
                proofOfPurchraseAttached = true;
            }
            else if (NoRadioButton.Checked)
            {
                proofOfPurchraseAttached = false;
            }
            else
            {
                Console.WriteLine("no proof of purchase attached selected");
            }
            DateTime dateReceived = DateReceivedTimePicker.Value;
            Record rc = new Record(fname, mname, lname, address_1, address_2, city, state, zipCode, gender, phNumber, email, proofOfPurchraseAttached,
                dateReceived, dateReceived,dateReceived, 0);
            Console.WriteLine(rc.IsValid());
            if (rc.IsValid())
            {
                Console.WriteLine(rc);
                int count = this.data.Count + 1;
                if (!this.set.Contains(rc))
                {
                    this.data.Add(count++, rc);
                    this.set.Add(rc);
                }
                Console.WriteLine(this.data.Count);
                Console.WriteLine(this.set.Count);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StateTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
