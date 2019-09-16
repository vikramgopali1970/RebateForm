using System;

public class Record
{
    private String fname;
    private char mname;
    private String lname;
    private String address_1;
    private String address_2;
    private String city;
    private String state;
    private String zipCode;
    private char gender;
    private String phNumber;
    private String emailId;
    private Boolean proofOfPurchraseAttached;
    private DateTime dateReceived;

    private DateTime firstCharEntered;
    private DateTime savedRecord;
    private int backSpaceUsed;


	public Record()
	{
	}

    public string Fname { get => fname; set => fname = value; }
    public char Mname { get => mname; set => mname = value; }
    public string Lname { get => this.lname; set => this.lname = value; }
    public string City { get => city; set => city = value; }
    public string State { get => state; set => state = value; }
    public string ZipCode { get => zipCode; set => zipCode = value; }
    public char Gender { get => gender; set => gender = value; }
    public string PhNumber { get => phNumber; set => phNumber = value; }
    public string EmailId { get => emailId; set => emailId = value; }
    public bool ProofOfPurchraseAttached { get => proofOfPurchraseAttached; set => proofOfPurchraseAttached = value; }
    public DateTime DateReceived { get => dateReceived; set => dateReceived = value; }
    public DateTime FirstCharEntered { get => firstCharEntered; set => firstCharEntered = value; }
    public DateTime SavedRecord { get => savedRecord; set => savedRecord = value; }
    public int BackSpaceUsed { get => backSpaceUsed; set => backSpaceUsed = value; }
    public string Address_1 { get => address_1; set => address_1 = value; }
    public string Address_2 { get => address_2; set => address_2 = value; }
}
