using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forex.Models
{
    public class directmodel
    {
        public string indexid { get; set; }
        public string UserId { get; set; }
        public string Package { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string ActiveStatus { get; set; }
        public string date { get; set; }
        public string activedate { get; set; }
        public string leg { get; set; }
        public string image { get; set; }
        public string Email { get; set; }
        public string TotalBusiness { get; set; }
        public string RegDate { get; set; }
        public string ActiveDate { get; set; }
        public string Sponsorid { get; set; }
        public string plann { get; set; }
        public string ranks { get; set; }

    }
    public class directlist
    {
        public List<directmodel> directtotal { get; set; }
    }


    public class dashboardmodel
    {
        public class Data
        {
            public string token { get; set; }
            public int expiry { get; set; }
        }

        public class btoken
        {
            public string status { get; set; }
            public string subCode { get; set; }
            public string message { get; set; }
            public Data data { get; set; }
        }

        public List<couponwallet> couponwalletl { get; set; }
        public string indexid { get; set; }
        public string house { get; set; }
        public string car { get; set; }
        public string franchise { get; set; }
        public string kbc { get; set; }
        public string popup { get; set; }
        public string franchiseamountunt { get; set; }
        public string travral { get; set; }
        public string planname { get; set; }
        public string idcard { get; set; }
        public string total { get; set; }
        public string daily { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string turnover { get; set; }
        public string level { get; set; }
        public string invest { get; set; }
        public string Photo { get; set; }
        public string direct { get; set; }
        public string activedirect { get; set; }
        public string activeteam { get; set; }
        public string matching { get; set; }
        public string matrix { get; set; }
        public string royality { get; set; }
        public string club { get; set; }
        public string paymentrequest { get; set; }
        public string Totalcount { get; set; }
        public string todaycount { get; set; }
        public string Totalinvest { get; set; }
        public string amount { get; set; }
        public string netamount { get; set; }
        public string regdate { get; set; }
        public string rank { get; set; }
        public string activedate { get; set; }
        public string todayinvest { get; set; }
        public string package { get; set; }
        public string unpaiddirect { get; set; }
        public string paiddirect { get; set; }
        public string bronze { get; set; }
        public string silver { get; set; }
        public string energy { get; set; }
        public string ActiveStatus { get; set; }       
        public string GreenWallet { get; set; }
        public string communityIncome { get; set; }
        public string Reward { get; set; }
        public string DirectIncome { get; set; }
        public string TransferGreenFund { get; set; }
        public string RoiOnRoi { get; set; }
        public string team { get; set; }
        public string crowdwallet { get; set; }
        public string GreenBalance { get; set; }
        public string Downline { get; set; }
        public string charity { get; set; }
        public string charityw { get; set; }
        public string charitycapping { get; set; }
        public string vol { get; set; }
        public string prelaunchcapping { get; set; }
        public string locks { get; set; }
        public string unlocks { get; set; }
        public string persent { get; set; }
    }
    
    public class dashboardlist
    {
        public List<dashboardmodel> directtotal { get; set; }
    }
}

