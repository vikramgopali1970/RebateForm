using System;
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
        private Nullable<char> mname;
        private String lname;
        private String address_1;
        private String address_2;
        private String city;
        private String state;
        private String zipCode;
        private Nullable<char> gender;
        private String phNumber;
        private String emailId;
        private Nullable<Boolean> proofOfPurchraseAttached;
        private DateTime dateReceived;

        private DateTime firstCharEntered;
        private DateTime savedRecord;
        private int backSpaceUsed;

        public Record()
        {
        }

        public Record(string fname, char? mname, string lname, string address_1, string address_2, string city, 
            string state, string zipCode, char? gender, string phNumber, string emailId, bool? proofOfPurchraseAttached, 
            DateTime dateReceived, DateTime firstCharEntered, DateTime savedRecord, int backSpaceUsed)
        {
            this.fname = fname;
            this.Mname1 = mname;
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
            return "("+this.fname+","+this.mname + ","+this.lname + ","+this.address_1 + ","+this.address_2 + ","+
                this.city + ","+this.state + ","+this.zipCode + ","+this.gender + ","+this.phNumber + ","+this.emailId + ","+
                proofOfPurchraseAttached + ","+this.dateReceived+")";
        }

        public Boolean IsValid()
        {
            if (this.fname.Length == 0 || this.lname.Length == 0 || this.address_1.Length == 0 || this.city.Length == 0 ||
                this.state.Length == 0 || this.zipCode.Length == 0 || this.phNumber.Length != 10 || this.emailId.Length == 0)
            {
                return false;
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(this.emailId);
            if (!match.Success)
            {
                return false;
            }
            return true;
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
        public char? Mname1 { get => mname; set => mname = value; }
        public char? Gender { get => gender; set => gender = value; }
        public bool? ProofOfPurchraseAttached { get => proofOfPurchraseAttached; set => proofOfPurchraseAttached = value; }

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
