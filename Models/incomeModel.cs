using System.Collections.Generic;

namespace forex.Models
{
    public class payout
    {
        public string id { get; set; }
        public string entity { get; set; }
        public string fund_account_id { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public Notes notes { get; set; }
        public int fees { get; set; }
        public int tax { get; set; }
        public string status { get; set; }
        public object utr { get; set; }
        public string mode { get; set; }
        public string purpose { get; set; }
        public string reference_id { get; set; }
        public string narration { get; set; }
        public object batch_id { get; set; }
        public StatusDetails status_details { get; set; }
        public int created_at { get; set; }
    }

    public class StatusDetails
    {
        public string description { get; set; }
        public string source { get; set; }
        public string reason { get; set; }
    }

    public class incomeModel

    {
        public string Userid { get; set; }
        public string contactid { get; set; }
        public string faccount { get; set; }
        public string tstatus { get; set; }
        public string Detail { get; set; }
        public string mobile { get; set; }
        public string InOut { get; set; }
        public string Amount { get; set; }
        public string Admin { get; set; }
        public string NetAmount { get; set; }
        public string tDate { get; set; }
        public string investedid { get; set; }
        public string direct { get; set; }
        public float amount { get; set; }
        public string amount1 { get; set; }
        public string indexid { get; set; }
        public string Name { get; set; } 
        public string AdminCharge { get; set; }
        public string TDS { get; set; }
        public string paidstatus { get; set; }
        public string Paiddetails { get; set; }
        public string pdate { get; set; }
        public string franchiseid { get; set; }
        public string branch { get; set; }
        public string accountno { get; set; }
        public string bankname { get; set; }
        public string ifsc { get; set; }
        public string totalamount { get; set; }
        public string message { get; set; }
        public string tamount { get; set; }
        public string PaymentMedium { get; set; }
        public string diamond { get; set; }
        public string gold { get; set; }
        public string pearl { get; set; }
        public string toapz { get; set; }
        public string nwf { get; set; }


        public string diamondd { get; set; }
        public string goldd { get; set; }
        public string pearld { get; set; }
        public string toapzd { get; set; }
        public string nwfd { get; set; }
    }
    public class income: incomeModel
    {
        public List<incomeModel> incomelist { get; set; }
        
    }
}
