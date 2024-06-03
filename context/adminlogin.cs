using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace forex.context
{
    public class adminlogin
    {
        public modlogin userexpertfun(modlogin logmodel, string connectionString)
        {
            modlogin obm = new modlogin();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proLoginUser", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@UserId", logmodel.userid);
                cmd.Parameters.AddWithValue("@Password", logmodel.password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    obm.userid = ds.Tables[1].Rows[0]["UserId"].ToString();
                    obm.Mobile = ds.Tables[1].Rows[0]["Mobile"].ToString();
                    obm.emailaddress = ds.Tables[1].Rows[0]["email"].ToString();
                    obm.name = ds.Tables[1].Rows[0]["Name"].ToString();
                    obm.photo = ds.Tables[1].Rows[0]["photo"].ToString();
                    obm.result = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            return obm;
        }

        public modlogin forgot(modlogin logmodel, string connectionString)
        {
            modlogin obm = new modlogin();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proforgot", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@UserId", logmodel.userid);
                cmd.Parameters.AddWithValue("@Password", logmodel.password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    obm.emailaddress = ds.Tables[1].Rows[0]["UserId"].ToString();
                    obm.password = ds.Tables[1].Rows[0]["Password"].ToString();
                    obm.name = ds.Tables[1].Rows[0]["Name"].ToString();
                    obm.result = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            return obm;
        }


        public string fun(modlogin logmodel, string connectionString)
        {
            modlogin obm = new modlogin();
           
            List<modlogin> studentList = new List<modlogin>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proLoginAdmin", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@UserId", logmodel.userid);
                cmd.Parameters.AddWithValue("@Password", logmodel.password);
                //Showing the data
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    obm.userid = ds.Tables[1].Rows[0]["UserId"].ToString();
                    obm.password = ds.Tables[1].Rows[0]["Password"].ToString();
                    obm.result = ds.Tables[0].Rows[0][0].ToString();
                        
                }
            }
              return obm.result;
        }

        public modlogin data(modlogin output, string connectionString)
        {          
            List<modlogin> studentList = new List<modlogin>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proiUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };               
                
                cmd.Parameters.AddWithValue("@Name", output.name);
                cmd.Parameters.AddWithValue("@Email", output.emailaddress);
                cmd.Parameters.AddWithValue("@Sponsorid", output.Sponsorid);
                cmd.Parameters.AddWithValue("@Mobile", output.Mobile);
                cmd.Parameters.AddWithValue("@City", output.city);
                cmd.Parameters.AddWithValue("@Password", output.password);
                cmd.Parameters.AddWithValue("@ConfirmPassword", output.ConfirmPassword);
                cmd.Parameters.AddWithValue("@Leg",output.Leg);
                cmd.Parameters.AddWithValue("@ParentId", output.parentid);
                cmd.Parameters.AddWithValue("@coupon", output.coupon);
                cmd.Parameters.AddWithValue("@plan", output.plan);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                 sda.Fill(ds);
                modlogin srq = new modlogin();
                srq.userid = ds.Tables[1].Rows[0][0].ToString();
                srq.Sponsorid = output.Sponsorid;
                srq.Mobile = output.Mobile;
                return srq;
            }
        }
        public modlogin datas(modlogin output, string connectionString)
        {
            List<modlogin> studentList = new List<modlogin>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proregister", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Name", output.name);
                cmd.Parameters.AddWithValue("@Email", output.emailaddress);
                cmd.Parameters.AddWithValue("@Sponsorid", output.Sponsorid);
                cmd.Parameters.AddWithValue("@Mobile", output.Mobile);
                cmd.Parameters.AddWithValue("@City", output.city);
                cmd.Parameters.AddWithValue("@Password", output.password);
                //cmd.Parameters.AddWithValue("@ConfirmPassword", output.ConfirmPassword);
                cmd.Parameters.AddWithValue("@Leg", output.Leg);
                cmd.Parameters.AddWithValue("@ParentId", output.parentid);
                cmd.Parameters.AddWithValue("@plan", output.plan);
               // cmd.Parameters.AddWithValue("@coupon", output.coupon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                modlogin srq = new modlogin();
                srq.userid = ds.Tables[1].Rows[0][0].ToString();
                srq.password = ds.Tables[2].Rows[0][0].ToString();
                srq.plan = ds.Tables[3].Rows[0][0].ToString();

                srq.Sponsorid = output.Sponsorid;
                srq.Mobile = output.Mobile;
                return srq;
            }
        }

        public modlogin regdon(modlogin output, string connectionString)
        {
            List<modlogin> studentList = new List<modlogin>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prodonet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Name", output.name);
                cmd.Parameters.AddWithValue("@Email", output.emailaddress);
                cmd.Parameters.AddWithValue("@amount", output.amount);
                cmd.Parameters.AddWithValue("@Mobile", output.Mobile);
                cmd.Parameters.AddWithValue("@pan", output.pan);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                modlogin srq = new modlogin();
                srq.userid = ds.Tables[1].Rows[0][0].ToString();
                
                return srq;
            }
        }
        public modlogin username(string id, string connectionString)
        {

            List<couponwallet> listcouponwallet = new List<couponwallet>();
            List<couponwallet> listcouponwallet1 = new List<couponwallet>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();
                cmd.Parameters.AddWithValue("@action", "byid");
                cmd.Parameters.AddWithValue("@userid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                modlogin m = new modlogin();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    m.name = ds.Tables[0].Rows[0]["name"].ToString();
                    m.userid = ds.Tables[0].Rows[0]["userid"].ToString();
                    m.rank= ds.Tables[0].Rows[0]["Designation1"].ToString();
                    m.result = ds.Tables[0].Rows[0]["ActiveDate"].ToString();
                    m.rank = ds.Tables[0].Rows[0]["Designation1"].ToString();
                    m.photo = ds.Tables[0].Rows[0]["photo"].ToString();
                    m.status = ds.Tables[2].Rows[0][0].ToString();



                }
                else
                {
                    m.name = "No Data Exists";
                }


                for (int i = 0; i < ds.Tables[3].Rows.Count; i++)
                {
                    couponwallet srqx = new couponwallet();
                    srqx.couponid = ds.Tables[3].Rows[i]["couponid"].ToString();
                    srqx.couponamount = ds.Tables[3].Rows[i]["Couponamount"].ToString();
                    listcouponwallet.Add(srqx);
                }
                m.couponwalletslist = listcouponwallet;
                for (int i = 0; i < ds.Tables[4].Rows.Count; i++)
                {
                    couponwallet srqx = new couponwallet();
                    srqx.indexid= ds.Tables[4].Rows[i]["indexid"].ToString();
                    srqx.amount = ds.Tables[4].Rows[i]["planamount"].ToString();
                    srqx.planname = ds.Tables[4].Rows[i]["planname"].ToString();
                    listcouponwallet1.Add(srqx);
                }
                m.couponwalletslist = listcouponwallet1;
                m.needan= ds.Tables[5].Rows[0][0].ToString();
                m.kbc= ds.Tables[6].Rows[0][0].ToString();
                con.Close();

                return m;
            }
        }

        public modlogins baln(string id, string connectionString)
        {

            List<couponwallet> listcouponwallet = new List<couponwallet>();
            List<couponwallet> listcouponwallet1 = new List<couponwallet>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();
                cmd.Parameters.AddWithValue("@action", "findbalmain");
                cmd.Parameters.AddWithValue("@userid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                modlogins m = new modlogins();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    m.main = ds.Tables[0].Rows[0][0].ToString();
                    m.crowd = ds.Tables[1].Rows[0][0].ToString();
                   



                }
                

                con.Close();

                return m;
            }
        }

        public modlogin usernames(string id, string connectionString)
        {

            List<couponwallet> listcouponwallet = new List<couponwallet>();
            List<couponwallet> listcouponwallet1 = new List<couponwallet>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();
                cmd.Parameters.AddWithValue("@action", "byid");
                cmd.Parameters.AddWithValue("@userid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                modlogin m = new modlogin();
               
                for (int i = 0; i < ds.Tables[4].Rows.Count; i++)
                {
                    couponwallet srqx = new couponwallet();
                    srqx.indexid = ds.Tables[4].Rows[i]["indexid"].ToString();
                   
                    srqx.amount = ds.Tables[4].Rows[i]["planamount"].ToString();
                    srqx.planname = ds.Tables[4].Rows[i]["planname"].ToString();

                    listcouponwallet1.Add(srqx);
                }
                m.couponwalletslist = listcouponwallet1;
                con.Close();

                return m;
            }
        }


        public modlogin addfundpaymet(string id ,string uid, string connectionString)
        {
            

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaymentaddfund", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@transactionId", id);
                cmd.Parameters.AddWithValue("@orderid", uid);
               
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                modlogin srq = new modlogin();
                //srq.userid = ds.Tables[1].Rows[0][0].ToString();

                return srq;
            }
        }

        public modlogin paymet(string id, string uid, string connectionString)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propayment", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@transactionId", id);
                cmd.Parameters.AddWithValue("@userid", uid);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                modlogin srq = new modlogin();
                srq.userid = ds.Tables[1].Rows[0][0].ToString();

                return srq;
            }
        }

        public modlogin paymets(string id, string uid, string connectionString)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propaymentdonet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@transactionId", id);
                cmd.Parameters.AddWithValue("@userid", uid);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                modlogin srq = new modlogin();
                //srq.userid = ds.Tables[1].Rows[0][0].ToString();

                return srq;
            }
        }
    }
}

