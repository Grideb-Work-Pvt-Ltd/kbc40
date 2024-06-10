using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace forex.context
{
    public class directcontext
    {
        public directlist directsee(string uid ,string connectionString)
        {

            directlist tl = new directlist();

            List<directmodel> orderListO = new List<directmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "referral");
                cmd.Parameters.AddWithValue("UserId", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    directmodel srq = new directmodel();
                    srq.UserId = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.Package = ds.Tables[0].Rows[i]["Package"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.Email = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.ActiveDate = ds.Tables[0].Rows[i]["ActiveDate"].ToString();
                    srq.TotalBusiness = ds.Tables[0].Rows[i]["TotalBusiness"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();
                    srq.plann = ds.Tables[0].Rows[i]["plann"].ToString();
                    srq.ranks = ds.Tables[0].Rows[i]["Ranks"].ToString();
                    srq.ActiveStatus = ds.Tables[0].Rows[i]["ActiveStatus"].ToString();
                    orderListO.Add(srq);
                }
                tl.directtotal = orderListO;

                return tl;
            }
        }

        public directlist charitysee( string connectionString)
        {

            directlist tl = new directlist();

            List<directmodel> orderListO = new List<directmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("procharitysummary", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    directmodel srq = new directmodel();
                    srq.UserId = ds.Tables[0].Rows[i]["UserId"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                    
                    //srq.date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.ranks = ds.Tables[0].Rows[i]["charitycapping"].ToString();
                    
                    srq.TotalBusiness = ds.Tables[0].Rows[i]["Total"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();
                    
                    orderListO.Add(srq);
                }
                tl.directtotal = orderListO;

                return tl;
            }
        }

        public string delcoupon(string id, string connectionString)
        {

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "del");
                cmd.Parameters.AddWithValue("@value", id);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "blocked";
            }
        }

        public dashboardmodel dashboardsee(string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proUserDashboard", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("UserId", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dashboardmodel srq = new dashboardmodel();
                srq.UserId = ds.Tables[0].Rows[0]["UserId"].ToString();
                srq.planname = ds.Tables[0].Rows[0]["planename"].ToString();
                srq.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                srq.regdate = ds.Tables[0].Rows[0]["RegDate"].ToString();
                srq.activedate = ds.Tables[0].Rows[0]["ActiveDate"].ToString();
                srq.direct = ds.Tables[0].Rows[0]["Direct"].ToString();
                srq.rank = ds.Tables[0].Rows[0]["Designation1"].ToString();
                srq.package = ds.Tables[0].Rows[0]["package"].ToString();
                srq.total = ds.Tables[1].Rows[0]["totalincome"].ToString();
                srq.crowdwallet = ds.Tables[2].Rows[0]["crowdwallet"].ToString();
                srq.matching = ds.Tables[3].Rows[0]["BinaryIncome"].ToString();
                srq.Downline = ds.Tables[4].Rows[0]["Downline"].ToString();
                srq.charity = ds.Tables[5].Rows[0][0].ToString();
                srq.charityw = ds.Tables[6].Rows[0][0].ToString();
                srq.charitycapping = ds.Tables[7].Rows[0][0].ToString();
                srq.vol = ds.Tables[8].Rows[0][0].ToString();
                srq.prelaunchcapping = ds.Tables[9].Rows[0][0].ToString();
                srq.locks = ds.Tables[9].Rows[0][1].ToString();
                srq.unlocks = ds.Tables[9].Rows[0][2].ToString();
                srq.persent = ds.Tables[10].Rows[0][0].ToString();
                srq.idcard = ds.Tables[11].Rows[0][0].ToString();
                srq.travral = ds.Tables[12].Rows[0][0].ToString();
                srq.house = ds.Tables[13].Rows[0][0].ToString();
                srq.car = ds.Tables[14].Rows[0][0].ToString();
                srq.franchiseamountunt = ds.Tables[15].Rows[0][0].ToString();
                srq.franchise = ds.Tables[16].Rows[0][0].ToString();
                srq.kbc = ds.Tables[17].Rows[0][0].ToString();
                srq.popup = ds.Tables[18].Rows[0]["popimg"].ToString();
                return srq;
            }
        }

        public dashboardmodel balsee(string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("probalance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@UserId", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dashboardmodel srq = new dashboardmodel();
               
                srq.total = ds.Tables[0].Rows[0]["balance"].ToString();
               
                return srq;
            }
        }

        public dashboardmodel balsees(string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prokbcbalance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@UserId", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dashboardmodel srq = new dashboardmodel();

                srq.total = ds.Tables[0].Rows[0]["balance"].ToString();

                return srq;
            }
        }

        public dashboardmodel donetionbalsee(string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prodonationbalance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@UserId", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dashboardmodel srq = new dashboardmodel();

                srq.total = ds.Tables[0].Rows[0]["balance"].ToString();

                return srq;
            }
        }


        public dashboardmodel franchisebalsees(string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("profranchisebalance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@UserId", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dashboardmodel srq = new dashboardmodel();

                srq.total = ds.Tables[0].Rows[0]["balance"].ToString();

                return srq;
            }
        }

        public dashboardmodel balseees(string uid,string type, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("profundtypebalance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@UserId", uid);
                cmd.Parameters.AddWithValue("@incometype", type);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dashboardmodel srq = new dashboardmodel();

                srq.total = ds.Tables[0].Rows[0]["balance"].ToString();

                return srq;
            }
        }



        public dashboardmodel admindashboardsee(string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proadmindashboardnew", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dashboardmodel srq = new dashboardmodel();
                srq.Totalcount = ds.Tables[0].Rows[0]["Totalcount"].ToString();
                srq.todaycount = ds.Tables[0].Rows[0]["todaycount"].ToString();
                srq.ActiveStatus = ds.Tables[0].Rows[0]["ActiveStatus"].ToString(); 
                srq.Totalinvest = ds.Tables[1].Rows[0]["Totalinvest"].ToString();
                srq.todayinvest = ds.Tables[1].Rows[0][1].ToString();
                srq.total = ds.Tables[2].Rows[0]["total"].ToString();
                srq.direct = ds.Tables[2].Rows[0]["Direct"].ToString();
                srq.Reward = ds.Tables[2].Rows[0]["Reward"].ToString();
                srq.level = ds.Tables[2].Rows[0]["level"].ToString();
                srq.daily = ds.Tables[2].Rows[0]["daily"].ToString();
                srq.team = ds.Tables[2].Rows[0]["team"].ToString();
                srq.amount = ds.Tables[3].Rows[0]["amount"].ToString();
                srq.netamount = ds.Tables[3].Rows[0]["netamount"].ToString();
                srq.GreenWallet = ds.Tables[4].Rows[0]["GreenWallet"].ToString();
                srq.TransferGreenFund = ds.Tables[4].Rows[0]["TransferGreenFund"].ToString(); 
                srq.communityIncome = ds.Tables[2].Rows[0]["communityIncome"].ToString(); 
                srq.zero = ds.Tables[6].Rows[0][0].ToString(); 
                srq.one = ds.Tables[7].Rows[0][0].ToString(); 
                srq.two = ds.Tables[8].Rows[0][0].ToString(); 
                srq.three = ds.Tables[9].Rows[0][0].ToString(); 
                srq.four = ds.Tables[10].Rows[0][0].ToString(); 
                srq.five = ds.Tables[11].Rows[0][0].ToString(); 
                srq.six = ds.Tables[12].Rows[0][0].ToString(); 
                srq.kbc = ds.Tables[13].Rows[0][0].ToString(); 
                srq.house = ds.Tables[14].Rows[0][0].ToString();
                srq.travral = ds.Tables[15].Rows[0][0].ToString();
                srq.car = ds.Tables[16].Rows[0][0].ToString(); 
               
                srq.donation = ds.Tables[17].Rows[0][0].ToString(); 
                srq.velfund = ds.Tables[18].Rows[0][0].ToString(); 

                return srq;
            }
        }

        public string turnovercalculation(string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("turnoverpool", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dashboardmodel srq = new dashboardmodel();
                
                return "turnover";
            }
        }
        public string blockid(string block, string userid, string connectionString)
        {

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "Updateblock");
                cmd.Parameters.AddWithValue("@BlockId", block);
                cmd.Parameters.AddWithValue("@userid", userid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "blocked";
            }
        }
    }
}
