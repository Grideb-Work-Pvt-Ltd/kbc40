using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forex.Models
{
    public class modlogins
    {
        public string main { get; set; }
        public string crowd { get; set; }
    }
    public class modlogin
    {
        public string name { get; set; }
        public string needan { get; set; }
        public string kbc { get; set; }
        public string photo { get; set; }
        public string pan { get; set; }
        public string plan { get; set; }
        public string amount { get; set; }
        public string userid { get;set; }
        public string emailaddress { get; set; }
        public string password { get; set; }
        public string result { get; set; }
        public string address { get; set; }
        public string Sponsorid { get; set; }
        public string city { get; set; }
        public string Mobile { get; set; }
        public string Leg { get; set; }
        public string status { get; set; }
        public string Transpassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string parentid { get; set; }
         public string rank { get; set; }
        public  string coupon { get; set; }
        public List<couponwallet> couponwalletslist { get; set; }
        public List<couponwallet> couponwalletslist1 { get; set; }
    }
    public class couponwallet
    {
        public string indexid { get; set; }
        public string planname { get; set; }
        public string couponid { get; set; }
        public string mass { get; set; }
        public string tcoupon { get; set; }
        public string amount { get; set; }
        public string couponamount { get; set; }
        public string userid { get; set; }
        public string name { get; set; }
        public string tname { get; set; }
        public string createby { get; set; }
        public string cdate { get; set; }
        public string inout { get; set; }

        public string transferto { get; set; }
        public string udatetime { get; set; }
        public string status { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string rank { get; set; }
        public string Direct { get; set; }
        public string hours { get; set; }
        public string coupon { get; set; }
        public string price { get; set; }
        public string edate { get; set; }
        public string statuss { get; set; }

    }

    public class couponlist
    {
        public List<couponwallet> couponslist { get; set; }
    }
    public class log: modlogin
    {
        public List<modlogin> reglist { get; set; }
    }
}
