using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebateForm
{
    public partial class RebateForm
    {
        private Record GetFieldDetails()
        {
            String fname = FnameTextBox.Text.Trim();
            String mname = "-";
            if (MnameTextBox.Text.Length > 0)
            {
                mname = MnameTextBox.Text;
            }
            String lname = LnameTextBox.Text.Trim();
            String address_1 = Address_1TextBox.Text.Trim();
            String address_2 = Address_2TextBox.Text.Trim();
            String city = CityTextBox.Text.Trim();
            String state = StateTextBox.Text.Trim();
            String zipCode = ZipCodeTextBox.Text.Trim();
            String gender = "-";
            if (this.genderTextBox.Text.Equals('Y'))
            {
                gender = "YES";
            }
            else
            {
                gender = "NO";
            }
            String phNumber = PhoneNumberMaskedTextBox.Text.Trim();
            String email = EmailIdTextBox.Text.Trim();
            String proofOfPurchraseAttached = "-";
            if(this.proofOfPurchaseTextBox.Text == 'Y'.ToString())
            {
                proofOfPurchraseAttached = "YES";
            }
            else if(this.proofOfPurchaseTextBox.Text == 'N'.ToString())
            {
                proofOfPurchraseAttached = "NO";
            }
            DateTime dateReceived = DateReceivedTimePicker.Value;
            Record rc = new Record(fname, mname, lname, address_1, address_2, city, state, zipCode, gender, phNumber, email, proofOfPurchraseAttached,
                dateReceived, dateReceived, dateReceived, 0);
            return rc;
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
            this.genderTextBox.Text = rc.Gender;
            this.PhoneNumberMaskedTextBox.Text = rc.PhNumber;
            this.EmailIdTextBox.Text = rc.EmailId;
            this.proofOfPurchaseTextBox.Text = rc.ProofOfPurchraseAttached.Substring(0, 1);
            this.DateReceivedTimePicker.Value = rc.DateReceived;
        }

        private void ClearFields(IEnumerable<TextBox> elements)
        {
            foreach (TextBox element in elements)
            {
                element.Clear();
            }
            this.DisableModifyMode();
        }

        private void AddItemToList(Record rc, int tag)
        {
            ListViewItem item = new ListViewItem(new[] { rc.Fname, rc.Lname, rc.PhNumber });
            item.Tag = tag;
            this.viewPortListView.Items.Add(item);
        }

        private void EnableModifyMode(int key, int index)
        {
            this.tag = key;
            this.index = index;
            this.add = false;
            this.modify = true;
        }

        private void DisableModifyMode()
        {
            this.add = true;
            this.modify = false;
            this.tag = -1;
            this.index = -1;
        }

        private Boolean EnableAddButton()
        {
            if(this.FnameTextBox.Text.Length == 0 || this.LnameTextBox.Text.Length == 0 || this.Address_1TextBox.Text.Length == 0 ||
               this.CityTextBox.Text.Length == 0 || this.StateTextBox.Text.Length == 0 || this.ZipCodeTextBox.Text.Length == 0 || 
                    this.genderTextBox.Text.Length == 0 || this.PhoneNumberMaskedTextBox.Text.Length != 10 || this.EmailIdTextBox.Text.Length == 0 ||
                    this.proofOfPurchaseTextBox.Text.Length == 0 || this.DateReceivedTimePicker.Value < new DateTime().Date)
            {
                Console.WriteLine(this.PhoneNumberMaskedTextBox.Text.Length);
                return false;
            }
            return true;
        }

        private void ExpandScreen(Control c)
        {
            int iHeight = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Height += iHeight;
            this.viewPortListView.Height += iHeight;
            this.saveButton.Height += iHeight;
            int iWidth = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.viewPortListView.Width += iWidth;
            //this.saveButton.Width += iWidth;
            this.Width += iWidth;
            this.CenterToScreen();
        }

    }
}
