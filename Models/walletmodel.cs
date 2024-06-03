using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace forex.Models
{
    public class walletmodel
    {
        public string Index { get; set; }
        public string incometype { get; set; }
        public string img { get; set; }
        public string couponid { get; set; }
        public string status { get; set; }
        public string byuserid { get; set; }
        public string userid { get; set; }
        public string username { get; set; }
        public float package { get; set; }
        public string details { get; set; }
        public string amount { get; set; }
        public string inout { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }
        public string Admin { get; set; }
        public string AdminCharge { get; set; }
        public string TDS { get; set; }
        public string NetAmount { get; set; }
        public string tDate { get; set; }
        public string investedid { get; set; }
        public string direct { get; set; }
        public string Detail { get; set; }
        public string pstatus { get; set; }
        public string SelectPlan { get; set; }
        public string value { get; set; }
        public string type { get; set; }
        public string sdate { get; set; }
        public string edate { get; set; }
        public string exdate { get; set; }


    }
    public class VerifyRequestModel
    {
        public string X_VERIFY { get; set; }
        public string base64 { get; set; }
        public string TransactionId { get; set; }
        public string MERCHANTID { get; set; }
        // Add other properties from the request if needed
    }

    public class PaymentInstrument
    {
        public string type { get; set; }
    }

    public class Roots
    {
        public string merchantId { get; set; }
        public string merchantTransactionId { get; set; }
        public string merchantUserId { get; set; }
        public int amount { get; set; }
        public string redirectUrl { get; set; }
        public string redirectMode { get; set; }
        public string callbackUrl { get; set; }
        public string mobileNumber { get; set; }
        public PaymentInstrument paymentInstrument { get; set; }
    }
    public class post
    {
        public string companykey { get; set; }
        public string companysecret { get; set; }
        public string occasion { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string detail { get; set; }
        public string no { get; set; }
        public string url { get; set; }


    }
    public class Rootsmodel
    {
        public string id { get; set; }
        public string entity { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string reference_id { get; set; }
        public object batch_id { get; set; }
        public bool active { get; set; }
        public notess notes { get; set; }
        public int created_at { get; set; }
    }

    public class BankAccount
    {
        public string name { get; set; }
        public string ifsc { get; set; }
        public string account_number { get; set; }
    }

    public class bank
    {
        public string contact_id { get; set; }
        public string account_type { get; set; }
        public BankAccount bank_account { get; set; }
    }

    public class fBankAccount
    {
        public string ifsc { get; set; }
        public string bank_name { get; set; }
        public string name { get; set; }
        public string account_number { get; set; }
        public List<object> notes { get; set; }
    }

    public class fbank
    {
        public string id { get; set; }
        public string entity { get; set; }
        public string contact_id { get; set; }
        public string account_type { get; set; }
        public fBankAccount bank_account { get; set; }
        public bool active { get; set; }
        public object batch_id { get; set; }
        public int created_at { get; set; }
    }


    public class Rootmodel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string type { get; set; }
        public string reference_id { get; set; }
        public notess notes { get; set; }
    }
    public class notess
    {
        public string notes_key_1 { get; set; }
        public string notes_key_2 { get; set; }
    }
    public class Notes
    {
        public string notes_key_1 { get; set; }
        public string notes_key_2 { get; set; }
    }
    public class finlbank
    {
        public string account_number { get; set; }
        public string fund_account_id { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public string mode { get; set; }
        public string purpose { get; set; }
        public bool queue_if_low_balance { get; set; }
        public string reference_id { get; set; }
        public string narration { get; set; }
        public Notees notes { get; set; }
    }
    public class Notees
    {
        public string notes_key_1 { get; set; }
        public string notes_key_2 { get; set; }
    }

    public class Rootes
    {
        public string userid { get; set; }
        public string password { get; set; }
        public string url { get; set; }
        public string adurl { get; set; }
        public string adimageurl { get; set; }
        public string adpost { get; set; }
        public object adimage { get; set; }
    }

   
    public class IncomeWallet : walletmodel
    {
        public IEnumerable<walletmodel> Incomewall { get; set; }
        public string tamount { get; set; }
    }
}

