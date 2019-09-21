using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RebateForm
{
    class Record
    {
        private String fname;
        private String mname;
        private String lname;
        private String address_1;
        private String address_2;
        private String city;
        private String state;
        private String zipCode;
        private String gender;
        private String phNumber;
        private String emailId;
        private String proofOfPurchraseAttached;
        private DateTime dateReceived;

        private DateTime firstCharEntered;
        private DateTime savedRecord;
        private int backSpaceUsed;


        public Record()
        {
        }

        public Record(string fname, String mname, string lname, string address_1, string address_2, string city, 
            string state, string zipCode, String gender, string phNumber, string emailId, String proofOfPurchraseAttached, 
            DateTime dateReceived, DateTime firstCharEntered, DateTime savedRecord, int backSpaceUsed)
        {
            this.fname = fname;
            this.Mname = mname;
            this.lname = lname;
            this.address_1 = address_1;
            this.address_2 = address_2;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.Gender = gender;
            this.phNumber = phNumber;
            this.emailId = emailId;
            this.ProofOfPurchraseAttached = proofOfPurchraseAttached;
            this.dateReceived = dateReceived;
            this.firstCharEntered = firstCharEntered;
            this.savedRecord = savedRecord;
            this.backSpaceUsed = backSpaceUsed;
        }

        public override String ToString() {
            return "("+this.fname+","+this.Mname + ","+this.lname + ","+this.address_1 + ","+this.address_2 + ","+
                this.city + ","+this.state + ","+this.zipCode + ","+this.Gender + ","+this.phNumber + ","+this.emailId + ","+
                ProofOfPurchraseAttached + ","+this.dateReceived+")";
        }

        public ArrayList IsValid()
        {
            ArrayList errors = new ArrayList();
            if(this.fname.Length == 0)
            {
                errors.Add("First Name cannot be Blank.");
            }
            if (this.lname.Length == 0)
            {
                errors.Add("Last Name cannot be Blank.");
            }
            if (this.address_1.Length == 0)
            {
                errors.Add("Address 1 cannot be Blank.");
            }
            if (this.city.Length == 0)
            {
                errors.Add("City Name cannot be Blank.");
            }
            if (this.state.Length == 0)
            {
                errors.Add("State Name cannot be Blank.");
            }
            if (this.zipCode.Length == 0)
            {
                errors.Add("Zipcode cannot be Blank.");
            }
            if (this.zipCode.Length != 5 || this.zipCode.Length != 9)
            {
                errors.Add("Zipcode is invalid.");
            }
            if (this.phNumber.Length < 10)
            {
                errors.Add("Enter valid Phone Number.");
            }
            if (this.emailId.Length == 0)
            {
                errors.Add("Email id cannot be Blank.");
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(this.emailId);
            if (!match.Success)
            {
                errors.Add("Enter a valid Email id.");
            }
            return errors;
        }

        public String[] ToArray()
        {
            return new string[]
            {
                this.fname,
                this.Mname.ToString(),
                this.lname,
                this.address_1,
                this.address_2,
                this.city,
                this.state,
                this.zipCode,
                this.Gender.ToString(),
                this.phNumber,
                this.emailId,
                this.ProofOfPurchraseAttached.ToString(),
                this.dateReceived.ToString(),
                this.firstCharEntered.ToString(),
                this.savedRecord.ToString(),
                this.backSpaceUsed.ToString()
            };
        }

        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Address_1 { get => address_1; set => address_1 = value; }
        public string Address_2 { get => address_2; set => address_2 = value; }
        public string State { get => state; set => state = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string PhNumber { get => phNumber; set => phNumber = value; }
        public string EmailId { get => emailId; set => emailId = value; }
        public DateTime DateReceived { get => dateReceived; set => dateReceived = value; }
        public DateTime FirstCharEntered { get => firstCharEntered; set => firstCharEntered = value; }
        public DateTime SavedRecord { get => savedRecord; set => savedRecord = value; }
        public int BackSpaceUsed { get => backSpaceUsed; set => backSpaceUsed = value; }
        public string City { get => city; set => city = value; }
        public string Mname { get => mname; set => mname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string ProofOfPurchraseAttached { get => proofOfPurchraseAttached; set => proofOfPurchraseAttached = value; }

        public override bool Equals(object obj)
        {
            return obj is Record record &&
                   fname == record.fname &&
                   lname == record.lname &&
                   phNumber == record.phNumber;
        }

        public override int GetHashCode()
        {
            var hashCode = 1860798100;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(lname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(phNumber);
            return hashCode;
        }
    }
}
