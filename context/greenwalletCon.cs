using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace forex.context
{
    public class greenwalletCon
    {
        public IncomeWallet transwalletsee(string uid, string connectionString)
        {

            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosGreenWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "mainwallet");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["InOut"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                tl.tamount = ds.Tables[1].Rows[0][0].ToString();
                return tl;
            }
        }

        public IncomeWallet ctranswalletsee(string uid, string connectionString)
        {

            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prochwallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
               // cmd.Parameters.AddWithValue("@action", "mainwallet");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["InOut"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                tl.tamount = ds.Tables[1].Rows[0][0].ToString();
                return tl;
            }
        }

        public string occasion(string occasion, string detail, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prooccasion", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@occasion", occasion);
                cmd.Parameters.AddWithValue("@detail", detail);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }


        public post postview(string connectionString)
        {

            post tl = new post();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prooccasion", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "select");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                post srq = new post();
                srq.occasion = ds.Tables[0].Rows[0]["occasion"].ToString();
                srq.detail = ds.Tables[0].Rows[0]["detail"].ToString();

                return srq;
            }
        }


        public IncomeWallet recivedwalletsee(string uid, string connectionString)
        {

            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosGreenWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "recivedcrowd");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.username = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Type"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["ReceiverAmount1"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["ReceiverAmount2"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                //tl.tamount = ds.Tables[1].Rows[0][0].ToString();
                return tl;
            }
        }
        public IncomeWallet givenwalletsee(string uid, string connectionString)
        {

            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosGreenWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "givencrowd");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.username = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Type"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["senderamount"].ToString();
                    //srq.inout = ds.Tables[0].Rows[i]["ReceiverAmount2"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                //tl.tamount = ds.Tables[1].Rows[0][0].ToString();
                return tl;
            }
        }


        public IncomeWallet crowdwalletsee(string uid, string connectionString)
        {

            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosGreenWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "crowdwallet");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["InOut"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                tl.tamount = ds.Tables[1].Rows[0][0].ToString();
                return tl;
            }
        }

        public IncomeWallet greenwalletsee(string uid,string connectionString)
        {

            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosGreenWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectone");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["InOut"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                tl.tamount = ds.Tables[1].Rows[0][0].ToString();
                return tl;
            }
        }

        public IncomeWallet kbcwalletsee(string uid, string connectionString)
        {

            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosGreenWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectoness");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["InOut"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                tl.tamount = ds.Tables[1].Rows[0][0].ToString();
                return tl;
            }
        }


        public IncomeWallet clubsee(string uid, string connectionString)
        {

            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prooccasion", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectincum");
               // cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.details = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["InOut"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                //tl.tamount = ds.Tables[1].Rows[0][0].ToString();
                return tl;
            }
        }

        public string kbcwalletin(walletmodel greenModel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proikbcWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", greenModel.userid);
                cmd.Parameters.AddWithValue("@Detail", greenModel.details);
                cmd.Parameters.AddWithValue("@Amount", greenModel.amount);
                cmd.Parameters.AddWithValue("@InOut", greenModel.inout);
                cmd.Parameters.AddWithValue("@tDate", greenModel.Date);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done"; 
            }
        }

        public string franchwalletin(walletmodel greenModel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifranchiseWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", greenModel.userid);
                cmd.Parameters.AddWithValue("@Detail", greenModel.details);
                cmd.Parameters.AddWithValue("@Amount", greenModel.amount);
                cmd.Parameters.AddWithValue("@InOut", greenModel.inout);
                cmd.Parameters.AddWithValue("@tDate", greenModel.Date);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }

        public string addfranchise(string fran,string userid,string date,string refral,string refralp, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("profranchiseadd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", userid);
                cmd.Parameters.AddWithValue("@fran", fran);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@refral", refral);
                cmd.Parameters.AddWithValue("@refralp", refralp);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }



        public string incometypewalletin(walletmodel greenModel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundincometypeWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", greenModel.userid);
                cmd.Parameters.AddWithValue("@Detail", greenModel.details);
                cmd.Parameters.AddWithValue("@Amount", greenModel.amount);
                cmd.Parameters.AddWithValue("@InOut", greenModel.inout);
                cmd.Parameters.AddWithValue("@tDate", greenModel.Date);
                cmd.Parameters.AddWithValue("@incometype", greenModel.incometype);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }


        public string greenwalletin(walletmodel greenModel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proiGreenWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", greenModel.userid);
                cmd.Parameters.AddWithValue("@Detail", greenModel.details);
                cmd.Parameters.AddWithValue("@Amount", greenModel.amount);
                cmd.Parameters.AddWithValue("@InOut", greenModel.inout);
                cmd.Parameters.AddWithValue("@tDate", greenModel.Date);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }


        public string greenwalletins(walletmodel greenModel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proimembertomember", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", greenModel.userid);
                cmd.Parameters.AddWithValue("@Detail", greenModel.details);
                cmd.Parameters.AddWithValue("@Amount", greenModel.amount);
                cmd.Parameters.AddWithValue("@InOut", greenModel.inout);
                cmd.Parameters.AddWithValue("@tDate", greenModel.Date);
                cmd.Parameters.AddWithValue("@byuserid", greenModel.byuserid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }

        public string greenwalletinskbc(walletmodel greenModel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proimembertomemberkbc", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", greenModel.userid);
                cmd.Parameters.AddWithValue("@Detail", greenModel.details);
                cmd.Parameters.AddWithValue("@Amount", greenModel.amount);
                cmd.Parameters.AddWithValue("@InOut", greenModel.inout);
                cmd.Parameters.AddWithValue("@tDate", greenModel.Date);
                cmd.Parameters.AddWithValue("@byuserid", greenModel.byuserid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }






        public string charitywalletin(walletmodel greenModel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proicharityWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", greenModel.userid);
                cmd.Parameters.AddWithValue("@Detail", greenModel.details);
                cmd.Parameters.AddWithValue("@Amount", greenModel.amount);
                cmd.Parameters.AddWithValue("@InOut", greenModel.inout);
                cmd.Parameters.AddWithValue("@tDate", greenModel.Date);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }
        public string donationwalletin(walletmodel greenModel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proidonationWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", greenModel.userid);
                cmd.Parameters.AddWithValue("@Detail", greenModel.details);
                cmd.Parameters.AddWithValue("@Amount", greenModel.amount);
                cmd.Parameters.AddWithValue("@InOut", greenModel.inout);
                cmd.Parameters.AddWithValue("@tDate", greenModel.Date);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }

        public string crowdwalletin(walletmodel greenModel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proiCrowdWallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@UserId", greenModel.userid);
                cmd.Parameters.AddWithValue("@Detail", greenModel.details);
                cmd.Parameters.AddWithValue("@Amount", greenModel.amount);
                cmd.Parameters.AddWithValue("@InOut", greenModel.inout);
                cmd.Parameters.AddWithValue("@tDate", greenModel.Date);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }
        public string greenwalletuserid(string uid,walletmodel greenModeluseid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ProiInvestPay", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "select");
                cmd.Parameters.AddWithValue("@UserId", greenModeluseid.userid);
                cmd.Parameters.AddWithValue("@amount", greenModeluseid.package);
                cmd.Parameters.AddWithValue("byuserid", uid);
                cmd.Parameters.AddWithValue("@roi", greenModeluseid.SelectPlan);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }

        public string addpayfund(string uid, walletmodel greenModeluseid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proaddpayfund", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
               
                cmd.Parameters.AddWithValue("@amount", greenModeluseid.amount);
                cmd.Parameters.AddWithValue("userid", uid);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][0].ToString(); ;
            }
        }
        public string findlastpay(string uid,  string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prolastaddfund", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

               // cmd.Parameters.AddWithValue("@amount", greenModeluseid.amount);
                cmd.Parameters.AddWithValue("userid", uid);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][0].ToString(); ;
            }
        }
        public income incomesee(string connectionString)
        {

            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proUserIncome", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "showbyuserwithType");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incomeModel srq = new incomeModel();
                    srq.Userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.InOut = ds.Tables[0].Rows[i]["InOut"].ToString();
                    srq.Admin = ds.Tables[0].Rows[i]["Admin"].ToString();
                    srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.NetAmount = ds.Tables[0].Rows[i]["NetAmount"].ToString();
                    srq.investedid = ds.Tables[0].Rows[i]["investedid"].ToString();

                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;

                return tl;
            }
        }

    }
}
