using System.Collections.Generic;

namespace forex.Models
{
    public class userlistModel
    {
        public string indexid { get; set; }
        public string crowd { get; set; }
        public string planename { get; set; }
        public string main { get; set; }
        public string nominee { get; set; }
        public string popup { get; set; }
        public string popups { get; set; }
        public string name { get; set; }
        public string pin { get; set; }
        public string state { get; set; }
        public string emailaddress { get; set; }
        public string password { get; set; }
        public string result { get; set; }
        public string address { get; set; }
        public string Sponsorid { get; set; }
        public string Sponsorname { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string userid { get; set; }
        public string package { get; set; }
        public string date { get; set; }
        public string RegDate { get; set; }
        public string ActiveDate { get; set; }
        public string Transpassword { get; set; }
        public string accountno { get; set; }
        public string status { get; set; }
        public string TotalBusiness { get; set; }     
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string message { get; set; }
        public string designation { get; set; }
        public string direct { get; set; }
        public string parentid { get; set; }
        public string parentname { get; set; }
        public string pancard { get; set; }
        public string image { get; set; }
        public string pincode { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string father { get; set; }
        public string adhaar { get; set; }
        public string kbcb { get; set; }
        public string type { get; set; }
        public string latest1 { get; set; }
        public string latest2 { get; set; }
        public string latest3 { get; set; }
        public string latest4 { get; set; }
        public string latest11 { get; set; }
        public string latest21 { get; set; }
        public string latest31{ get; set; }
        public string latest41 { get; set; }
        public string event1 { get; set; }
        public string event2 { get; set; }
        public string event3 { get; set; }
        public string event4 { get; set; }
        public string event5 { get; set; }
        public string event6 { get; set; }
        public string vol1 { get; set; }
        public string vol2 { get; set; }
        public string vol3 { get; set; }
        public string blog1 { get; set; }
        public string blog2 { get; set; }
        public string blog3 { get; set; }
        public string video { get; set; }
        public string Silver { get; set; }
        public string Gold { get; set; }
        public string Pearl { get; set; }
        public string ccapping { get; set; }
        public string pcapping { get; set; }
    }
    public class user: userlistModel
    {
        public List<userlistModel> reglist { get; set; }
        public List<userlistModel> reglists { get; set; }
    }
}
