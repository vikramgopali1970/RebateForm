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
            char mname = '-';
            if (MnameTextBox.Text.Length > 0)
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
            }
            else if (FemaleRadioButton.Checked)
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

    }
}
