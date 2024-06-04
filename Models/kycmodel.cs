using System.Collections.Generic;

namespace forex.Models
{
    public class Datas
    {
        public string nameAtBank { get; set; }
        public string refId { get; set; }
        public string bankName { get; set; }
        public string utr { get; set; }
        public string city { get; set; }
        public string branch { get; set; }
        public int micr { get; set; }
    }
    public class adharv
    {
        public string name { get; set; }
        public string yob { get; set; }
        public string gender { get; set; }
        public string uid { get; set; }
        public string state { get; set; }
        public string pincode { get; set; }
        public string address { get; set; }
        public bool valid { get; set; }
        public string status { get; set; }
        public string reference_id { get; set; }
        public string verification_id { get; set; }
        public string message { get; set; }
    }


    public class panmod
    {
        public string name { get; set; }
        public string pan_type { get; set; }
        public string dob { get; set; }
        public string father { get; set; }
        public string pan { get; set; }
        public bool valid { get; set; }
        public string age { get; set; }
        public string status { get; set; }
        public string reference_id { get; set; }
        public string verification_id { get; set; }
        public string message { get; set; }
    }

    public class bankveri
    {
        public string status { get; set; }
        public string subCode { get; set; }
        public string message { get; set; }
        public string accountStatus { get; set; }
        public string accountStatusCode { get; set; }
        public Datas data { get; set; }
    }


    public class kycmodel
    {
        public string StartDate { get; set; }
        public string dob { get; set; }
        public string pincode { get; set; }
        public string father { get; set; }
        public string EndDate { get; set; }
        public string SelfIncome { get; set; }
        public string RankF { get; set; }
        public string RankU { get; set; }
        public string Direct { get; set; }
        public string TTime { get; set; }
        public string DirectIncome { get; set; }
        public string TStatus { get; set; }
        public string SType { get; set; }
        public string GDirect { get; set; }
        public string GAmount { get; set; }
        public string Userid { get; set; }
        public string panbyt { get; set; }
        public string indexid { get; set; }
        public string kamount { get; set; }
        public string namount { get; set; }
        public string byuserid { get; set; }
        public string BankStatus { get; set; }
        public string contactid { get; set; }
        public string faccount { get; set; }
        public string KycStatus { get; set; }
        public string token { get; set; }
        public string pannumbr { get; set; }
        public string pancard { get; set; }
        public string adharnumber { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string adharfront { get; set; }
        public string adharback { get; set; }
        public string fileb { get; set; }
        public string bank { get; set; }
        public string accountno { get; set; }
        public string ifsc { get; set; }
        public string bankname { get; set; }
        public string branch { get; set; }
        public string city { get; set; }
        public string state { get; set; }
       
        public string amount { get; set; }
        public string transection { get; set; }
        public string oldpassword { get; set; }
        public string newpassword { get; set; }
        public string AccountHolderName { get; set; }
        public string Payment { get; set; }
        public string tdate { get; set; }
    }
    public class Data
    {
        public string token { get; set; }
        public int expiry { get; set; }
    }

    public class Root
    {
        public string status { get; set; }
        public string message { get; set; }
        public string subCode { get; set; }
        public Data data { get; set; }
    }
    public class kycmodellist: kycmodel
    {
        public List<kycmodel> kyclist { get; set; }
    }
}

