using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace forex.context
{
    public class kyccontext
    {
        public string kycin(string uid, kycmodel logo, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@UserId", uid);
                cmd.Parameters.AddWithValue("@action", "UpdateTXN");
                cmd.Parameters.AddWithValue("@Transpassword", logo.newpassword);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }

        public string bankin( string uid,kycmodel logo, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@action", "Updatebybank");
                cmd.Parameters.AddWithValue("@AccountNo", logo.accountno);
                cmd.Parameters.AddWithValue("@IFSC", logo.ifsc);
                cmd.Parameters.AddWithValue("@BankName", logo.bankname);
                cmd.Parameters.AddWithValue("@Branch", logo.branch);
                cmd.Parameters.AddWithValue("@AccountHolderName", logo.AccountHolderName);
                cmd.Parameters.AddWithValue("@AdharNo", logo.adharnumber);
                cmd.Parameters.AddWithValue("@city", logo.city);
                cmd.Parameters.AddWithValue("@state", logo.state);
                cmd.Parameters.AddWithValue("@PanNo", logo.pannumbr);
                cmd.Parameters.AddWithValue("@contactid", logo.contactid);
                cmd.Parameters.AddWithValue("@faccount", logo.faccount);
                cmd.Parameters.AddWithValue("@pincode", logo.pincode);
                cmd.Parameters.AddWithValue("@dob", logo.dob);
                cmd.Parameters.AddWithValue("@address", logo.address);
                cmd.Parameters.AddWithValue("@gender", logo.gender);
                cmd.Parameters.AddWithValue("@father", logo.father);
                cmd.Parameters.AddWithValue("@BankPassbook", "../upload/" + logo.bank);
                cmd.Parameters.AddWithValue("@PanCard", "../upload/" + logo.pancard); 
                cmd.Parameters.AddWithValue("@AdharCardfront", "../upload/" + logo.adharfront); 
                cmd.Parameters.AddWithValue("@AdharCardback", "../upload/" + logo.adharback); 
                 SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }


        public string franchisebankin(string uid, kycmodel logo, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@action", "Updatebybank");
                cmd.Parameters.AddWithValue("@byuserid", logo.Userid);
                cmd.Parameters.AddWithValue("@kamount", logo.KycStatus);
                cmd.Parameters.AddWithValue("@namount", logo.newpassword);
                cmd.Parameters.AddWithValue("@transection", logo.transection);
               
                cmd.Parameters.AddWithValue("@image", "../upload/" + logo.bank);
                 SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }


        public string bankins(string uid, kycmodel logo, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@action", "bankkycupdates");
                cmd.Parameters.AddWithValue("@AccountNo", logo.accountno);
                cmd.Parameters.AddWithValue("@IFSC", logo.ifsc);
                cmd.Parameters.AddWithValue("@BankName", logo.bankname);
                cmd.Parameters.AddWithValue("@Branch", logo.branch);
                cmd.Parameters.AddWithValue("@AccountHolderName", logo.AccountHolderName);
                cmd.Parameters.AddWithValue("@AdharNo", logo.adharnumber);
                cmd.Parameters.AddWithValue("@city", logo.city);
                cmd.Parameters.AddWithValue("@state", logo.state);
                cmd.Parameters.AddWithValue("@PanNo", logo.pannumbr);
                //cmd.Parameters.AddWithValue("@BankPassbook", "../upload/" + logo.bank);
                //cmd.Parameters.AddWithValue("@PanCard", "../upload/" + logo.pancard);
               // cmd.Parameters.AddWithValue("@AdharCardfront", "../upload/" + logo.adharfront);
                //cmd.Parameters.AddWithValue("@AdharCardback", "../upload/" + logo.adharback);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }


        public string active(string uid, kycmodel logo, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaytrans", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@userid", uid);               
                cmd.Parameters.AddWithValue("@Amount", logo.amount);
                cmd.Parameters.AddWithValue("@Transid", logo.transection);
                cmd.Parameters.AddWithValue("@Image", "../upload/" + logo.bank);
                cmd.Parameters.AddWithValue("@paystatus", "0");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }

        public string franchiseactive(string uid, kycmodel logo, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaytrans", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@kbcamount", logo.kamount);
                cmd.Parameters.AddWithValue("@needanamount", logo.namount);
                cmd.Parameters.AddWithValue("@byuserid", logo.byuserid);
              
                cmd.Parameters.AddWithValue("@Transid", logo.transection);
                cmd.Parameters.AddWithValue("@Image", "../upload/" + logo.bank);
                cmd.Parameters.AddWithValue("@paystatus", "0");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }


        public kycmodellist activesee(string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> noListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaytrans", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "selects");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    kycmodel srq = new kycmodel();

                    srq.Userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.bank = ds.Tables[0].Rows[i]["Image"].ToString();
                    srq.transection = ds.Tables[0].Rows[i]["Transid"].ToString();
                    noListO.Add(srq);
                }
                tl.kyclist = noListO;

                return tl;
            }
        }

        public kycmodellist activesees(string uid,string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> noListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaytrans", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "selects");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    kycmodel srq = new kycmodel();

                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.Userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.kamount = ds.Tables[0].Rows[i]["kbcAmount"].ToString();
                    srq.namount = ds.Tables[0].Rows[i]["needanAmount"].ToString();
                  
                    srq.bank = ds.Tables[0].Rows[i]["Image"].ToString();
                    srq.transection = ds.Tables[0].Rows[i]["Transid"].ToString();
                    noListO.Add(srq);
                }
                tl.kyclist = noListO;

                return tl;
            }
        }

        public kycmodellist updateactivesees(string id, string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> noListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaytrans", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "paids");
                cmd.Parameters.AddWithValue("@userid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

               

                return tl;
            }
        }


        public kycmodellist activsend(string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> noListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaytrans", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "paid");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    kycmodel srq = new kycmodel();

                    srq.Userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.tdate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.transection = ds.Tables[0].Rows[i]["InOut"].ToString();
                    noListO.Add(srq);
                }
                tl.kyclist = noListO;

                return tl;
            }
        }

        public kycmodellist activssend(string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> noListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaytrans", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "paidsss");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    kycmodel srq = new kycmodel();

                    srq.Userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.tdate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.transection = ds.Tables[0].Rows[i]["InOut"].ToString();
                    noListO.Add(srq);
                }
                tl.kyclist = noListO;

                return tl;
            }
        }




        public kycmodellist charitysend(string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> noListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaytrans", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "charity");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    kycmodel srq = new kycmodel();

                    srq.Userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.tdate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.transection = ds.Tables[0].Rows[i]["InOut"].ToString();
                    srq.AccountHolderName = ds.Tables[0].Rows[i]["name"].ToString();
                    srq.state = ds.Tables[0].Rows[i]["sponsorid"].ToString();
                    noListO.Add(srq);
                }
                tl.kyclist = noListO;

                return tl;
            }
        }

        public kycmodellist donationsend(string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> noListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaytrans", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "donation");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    kycmodel srq = new kycmodel();

                    srq.Userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.tdate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.transection = ds.Tables[0].Rows[i]["InOut"].ToString();
                    noListO.Add(srq);
                }
                tl.kyclist = noListO;

                return tl;
            }
        }


        public kycmodellist kycupdatesee(string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> noListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "All");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    kycmodel srq = new kycmodel();

                    srq.Userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.pannumbr = ds.Tables[0].Rows[i]["PanNo"].ToString();
                    srq.pancard = ds.Tables[0].Rows[i]["PanCard"].ToString();
                    srq.adharnumber = ds.Tables[0].Rows[i]["AdharNo"].ToString();
                    srq.adharfront = ds.Tables[0].Rows[i]["AdharCardfront"].ToString();
                    srq.adharback = ds.Tables[0].Rows[i]["AdharCardback"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["AccountNo"].ToString();
                    srq.ifsc = ds.Tables[0].Rows[i]["IFSC"].ToString();
                    srq.bankname = ds.Tables[0].Rows[i]["BankName"].ToString();
                    srq.branch = ds.Tables[0].Rows[i]["Branch"].ToString();
                    srq.bank = ds.Tables[0].Rows[i]["BankPassbook"].ToString();
                    noListO.Add(srq);
                }
                tl.kyclist = noListO;

                return tl;
            }
        }
        public kycmodel userkycupdatesee(string uid, string connectionString)
        {

            user tl = new user();

            List<kycmodel> orderListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "byID");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                kycmodel srq = new kycmodel();
                srq.Userid = ds.Tables[0].Rows[0]["userid"].ToString();
                srq.pannumbr = ds.Tables[0].Rows[0]["PanNo"].ToString();
                srq.pancard = ds.Tables[0].Rows[0]["PanCard"].ToString();
                srq.adharnumber = ds.Tables[0].Rows[0]["AdharNo"].ToString();
                srq.adharfront = ds.Tables[0].Rows[0]["AdharCardfront"].ToString();
                srq.adharback = ds.Tables[0].Rows[0]["AdharCardback"].ToString();
                srq.accountno = ds.Tables[0].Rows[0]["AccountNo"].ToString();
                srq.ifsc = ds.Tables[0].Rows[0]["IFSC"].ToString();
                srq.bankname = ds.Tables[0].Rows[0]["BankName"].ToString();
                srq.branch = ds.Tables[0].Rows[0]["Branch"].ToString();
                srq.bank = ds.Tables[0].Rows[0]["BankPassbook"].ToString();
                srq.AccountHolderName = ds.Tables[0].Rows[0]["AccountHolderName"].ToString();
                srq.state = ds.Tables[0].Rows[0]["STATE"].ToString();
                srq.city = ds.Tables[0].Rows[0]["city"].ToString();
                srq.pincode = ds.Tables[0].Rows[0]["pincode"].ToString();
                srq.dob = ds.Tables[0].Rows[0]["dob"].ToString();
                srq.address = ds.Tables[0].Rows[0]["address"].ToString();
                srq.gender = ds.Tables[0].Rows[0]["gender"].ToString();
                srq.father = ds.Tables[0].Rows[0]["father"].ToString();
                return srq;
            }
        }


    }
}
