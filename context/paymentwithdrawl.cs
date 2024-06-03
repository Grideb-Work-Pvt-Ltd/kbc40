using forex.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace forex.context
{
    public class paymentwithdrawl
    {
        public IncomeWallet paymentsummary(string uid, string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> noListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();
                cmd.Parameters.AddWithValue("@action", "allUser");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                tl.tamount = ds.Tables[1].Rows[0]["Total"].ToString();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["uDate"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["NetAmount"].ToString();
                    srq.TDS = ds.Tables[0].Rows[i]["TDS"].ToString();
                    srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.pstatus = ds.Tables[0].Rows[i]["kStatus"].ToString();
                    srq.AdminCharge = ds.Tables[0].Rows[i]["AdminCharge"].ToString();
                    srq.NetAmount = ds.Tables[0].Rows[i]["NetAmount"].ToString();
                    srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    noListO.Add(srq);
                }
                con.Close();
            }
            tl.Incomewall = noListO;
            return tl;
        }


        public IncomeWallet diposite(string uid, string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> noListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosDipositeWallet", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["InOut"].ToString();                  
                    noListO.Add(srq);
                }
                con.Close();
            }
            tl.Incomewall = noListO;
            return tl;
        }

        public IncomeWallet donetion(string uid, string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> noListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prodonetion", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                tl.tamount= ds.Tables[1].Rows[0][0].ToString();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.Index = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["InOut"].ToString();
                    noListO.Add(srq);
                }
                con.Close();
            }
            tl.Incomewall = noListO;
            return tl;
        }

        public IncomeWallet donetions(string uid,int id, string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> noListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prodonetions", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@indexid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                tl.tamount= ds.Tables[0].Rows[0]["Amount"].ToString();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.Index = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["InOut"].ToString();
                    noListO.Add(srq);
                }
                con.Close();
            }
            tl.Incomewall = noListO;
            return tl;
        }
    }
}

