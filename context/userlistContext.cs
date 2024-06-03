using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace forex.context
{
    public class userlistContext
    {
        public string coupon(string value, string type, string sdate, string edate, string exdate, string f, string gap, string qty, string connectionString)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@sdate", sdate);
                cmd.Parameters.AddWithValue("@edate", edate);
                cmd.Parameters.AddWithValue("@exdate", exdate);
                cmd.Parameters.AddWithValue("@gap", gap);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@img", "../upload/" + f);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "ok";
            }
        }

        public string kbcoffer( string sdate, string edate, string amount, string bonus,  string connectionString)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prokbcoffer", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
               
                cmd.Parameters.AddWithValue("@sdate", sdate);
                cmd.Parameters.AddWithValue("@edate", edate);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@bonus", bonus);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "ok";
            }
        }

        public string Needanoffer(string sdate, string edate, string sincome, string rf,string ru,string ttime,string direct,string directi, string stype, string gdirect, string gamount, string connectionString)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proNeedanoffer", con)
                {
                    CommandType = CommandType.StoredProcedure
                };


                cmd.Parameters.AddWithValue("@sdate", sdate);
                cmd.Parameters.AddWithValue("@edate", edate);
                cmd.Parameters.AddWithValue("@sincome", sincome);
                cmd.Parameters.AddWithValue("@rankf", rf);
                cmd.Parameters.AddWithValue("@ranku", ru);
                cmd.Parameters.AddWithValue("@ttime", ttime);
                cmd.Parameters.AddWithValue("@direct", direct);
                cmd.Parameters.AddWithValue("@directi", directi);
                cmd.Parameters.AddWithValue("@stype", stype);
                cmd.Parameters.AddWithValue("@gdirect", gdirect);
                cmd.Parameters.AddWithValue("@gamount", gamount);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "ok";
            }
        }


        public user userlistsee(string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

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
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.planename = ds.Tables[0].Rows[i]["planename"].ToString();
                    srq.emailaddress = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();
                    srq.Sponsorname = ds.Tables[0].Rows[i]["Sponsorname"].ToString();
                    srq.parentid = ds.Tables[0].Rows[i]["parentid"].ToString();
                    srq.parentname = ds.Tables[0].Rows[i]["parentname"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.City = ds.Tables[0].Rows[i]["City"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();
                    srq.ActiveDate = ds.Tables[0].Rows[i]["ActiveDate"].ToString();
                    srq.password = ds.Tables[0].Rows[i]["Password"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["AccountNo"].ToString();
                    srq.package = ds.Tables[0].Rows[i]["Package"].ToString();
                    srq.designation = ds.Tables[0].Rows[i]["DesignationRank"].ToString();
                    srq.direct = ds.Tables[0].Rows[i]["Direct"].ToString();
                    srq.status = ds.Tables[0].Rows[i]["status"].ToString();
                    srq.TotalBusiness = ds.Tables[0].Rows[i]["TotalBusiness"].ToString();
                    srq.pancard= ds.Tables[0].Rows[i]["panno"].ToString();
                    srq.ccapping = ds.Tables[0].Rows[i]["charitycapping"].ToString();
                    srq.pcapping = ds.Tables[0].Rows[i]["prelanunchcapping"].ToString();
                    srq.address = ds.Tables[0].Rows[i]["address"].ToString();
                    srq.image = ds.Tables[0].Rows[i]["photo"].ToString();
                   // srq.main = ds.Tables[1].Rows[i]["0"].ToString();
                   // srq.crowd = ds.Tables[2].Rows[i]["0"].ToString();
                    
                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }
        public user userlistsee2(string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "Alls");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.emailaddress = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();
                    srq.Sponsorname = ds.Tables[0].Rows[i]["Sponsorname"].ToString();
                    srq.parentid = ds.Tables[0].Rows[i]["parentid"].ToString();
                    srq.parentname = ds.Tables[0].Rows[i]["parentname"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.City = ds.Tables[0].Rows[i]["City"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();
                    srq.ActiveDate = ds.Tables[0].Rows[i]["ActiveDate"].ToString();
                    srq.password = ds.Tables[0].Rows[i]["Password"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.planename = ds.Tables[0].Rows[i]["planename"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["AccountNo"].ToString();
                    srq.package = ds.Tables[0].Rows[i]["Package"].ToString();
                    srq.designation = ds.Tables[0].Rows[i]["DesignationRank"].ToString();
                    srq.direct = ds.Tables[0].Rows[i]["Direct"].ToString();
                    srq.status = ds.Tables[0].Rows[i]["status"].ToString();
                    srq.TotalBusiness = ds.Tables[0].Rows[i]["TotalBusiness"].ToString();
                    srq.pancard = ds.Tables[0].Rows[i]["panno"].ToString();
                    srq.ccapping = ds.Tables[0].Rows[i]["charitycapping"].ToString();
                    srq.pcapping = ds.Tables[0].Rows[i]["prelanunchcapping"].ToString();
                   

                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }


        public user idcard(string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "idcard");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                   
                    srq.Sponsorname = ds.Tables[0].Rows[i]["Sponsorname"].ToString();
                    srq.parentid = ds.Tables[0].Rows[i]["detail"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["amount"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["tdate"].ToString();
                    srq.message = ds.Tables[0].Rows[i]["mobile"].ToString();
                    srq.City = ds.Tables[0].Rows[i]["DesignationRank"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();
                    srq.address = ds.Tables[0].Rows[i]["address"].ToString();
                    srq.image = ds.Tables[0].Rows[i]["photo"].ToString();
                   
                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }

        public user plan(string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proplankbc", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "select");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["planname"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["planamount"].ToString();
                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();

                   

                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }

        public string addplan(string name, string amount,  string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proplankbc", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@planname", name);
                cmd.Parameters.AddWithValue("@planamount", amount);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                
                return "done";
            }
        }

        public string plandelete(string name, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proplankbc", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "delete");
                cmd.Parameters.AddWithValue("@indexid", name);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                return "done";
            }
        }




        public kycmodellist userlistseekyc(string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> orderListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "requestbankkyc");
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
                    srq.AccountHolderName = ds.Tables[0].Rows[i]["AccountHolderName"].ToString();
                    srq.state = ds.Tables[0].Rows[i]["STATE"].ToString();
                    srq.city = ds.Tables[0].Rows[i]["city"].ToString();

                    orderListO.Add(srq);
                }
                tl.kyclist = orderListO;

                return tl;
            }
        }

        public user Idcard(string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

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
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.emailaddress = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();
                    srq.Sponsorname = ds.Tables[0].Rows[i]["Sponsorname"].ToString();
                    srq.parentid = ds.Tables[0].Rows[i]["parentid"].ToString();
                    srq.parentname = ds.Tables[0].Rows[i]["parentname"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.City = ds.Tables[0].Rows[i]["City"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();
                    srq.ActiveDate = ds.Tables[0].Rows[i]["ActiveDate"].ToString();
                    srq.password = ds.Tables[0].Rows[i]["Password"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["AccountNo"].ToString();
                    srq.package = ds.Tables[0].Rows[i]["Package"].ToString();
                    srq.designation = ds.Tables[0].Rows[i]["DesignationRank"].ToString();
                   

                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }


        public kycmodellist userlistseekycs(string id,string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> orderListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prokyc", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "select");
                cmd.Parameters.AddWithValue("@userid", id);
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
                    srq.AccountHolderName = ds.Tables[0].Rows[i]["AccountHolderName"].ToString();
                    srq.state = ds.Tables[0].Rows[i]["STATE"].ToString();
                    srq.city = ds.Tables[0].Rows[i]["city"].ToString();

                    orderListO.Add(srq);
                }
                tl.kyclist = orderListO;

                return tl;
            }
        }

        public kycmodellist noffer( string connectionString)
        {

            kycmodellist tl = new kycmodellist();

            List<kycmodel> orderListO = new List<kycmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proineedansee", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "select");
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    kycmodel srq = new kycmodel();
                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.StartDate = ds.Tables[0].Rows[i]["StartDate"].ToString();
                    srq.EndDate = ds.Tables[0].Rows[i]["EndDate"].ToString();
                    srq.SelfIncome = ds.Tables[0].Rows[i]["SelfIncome"].ToString();
                    srq.RankF = ds.Tables[0].Rows[i]["RankF"].ToString();
                    srq.RankU = ds.Tables[0].Rows[i]["RankU"].ToString();
                    srq.Direct= ds.Tables[0].Rows[i]["Direct"].ToString();
                    srq.TTime= ds.Tables[0].Rows[i]["TTime"].ToString();
                    srq.DirectIncome = ds.Tables[0].Rows[i]["DirectIncome"].ToString();
                    srq.SType = ds.Tables[0].Rows[i]["SType"].ToString();
                    srq.GDirect = ds.Tables[0].Rows[i]["GDirect"].ToString();
                    srq.GAmount = ds.Tables[0].Rows[i]["Gamount"].ToString();
                    
                    orderListO.Add(srq);
                }
                tl.kyclist = orderListO;

                return tl;
            }
        }




        public string updatekyc(string userid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "kycupdate");
                cmd.Parameters.AddWithValue("@UserId", userid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                string k = "Updated KYC";

                return k;
            }
        }

        public string rejectkyc(string userid, string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "kycreject");
                cmd.Parameters.AddWithValue("@UserId", userid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                string k = "Rejected KYC";

                return k;
            }
        }

        public string deloffer(string userid, string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prodelnoffer", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
               // cmd.Parameters.AddWithValue("@action", "kycreject");
                cmd.Parameters.AddWithValue("@UserId", userid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                string k = "Rejected KYC";

                return k;
            }
        }





        public user userlistsees(string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "newuser");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.emailaddress = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();
                  
                    srq.parentid = ds.Tables[0].Rows[i]["parentid"].ToString();
                   
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.City = ds.Tables[0].Rows[i]["City"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();
                  
                    srq.password = ds.Tables[0].Rows[i]["Password"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.result  = ds.Tables[0].Rows[i]["transactionid"].ToString();
                    
                   
                   
                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }

        public user donatesee(string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prodonetlist", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.emailaddress = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.pancard = ds.Tables[0].Rows[i]["pan"].ToString();
                   
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                   
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();

                    srq.accountno = ds.Tables[0].Rows[i]["amount"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.result = ds.Tables[0].Rows[i]["transationid"].ToString();



                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }

        public user userlistseess(string uid,string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "newusers");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.emailaddress = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();

                    srq.parentid = ds.Tables[0].Rows[i]["parentid"].ToString();

                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.City = ds.Tables[0].Rows[i]["City"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();

                    srq.password = ds.Tables[0].Rows[i]["Password"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();



                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }


        public user userprofilebydate(string userid,string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "Allbyuserid");
                cmd.Parameters.AddWithValue("@UserId", userid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.emailaddress = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();
                    srq.Sponsorname = ds.Tables[0].Rows[i]["Sponsorname"].ToString();
                    srq.parentid = ds.Tables[0].Rows[i]["parentid"].ToString();
                    srq.parentname = ds.Tables[0].Rows[i]["parentname"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.City = ds.Tables[0].Rows[i]["City"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();
                    srq.ActiveDate = ds.Tables[0].Rows[i]["ActiveDate"].ToString();
                    srq.password = ds.Tables[0].Rows[i]["Password"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["AccountNo"].ToString();
                    srq.package = ds.Tables[0].Rows[i]["Package"].ToString();
                    srq.designation = ds.Tables[0].Rows[i]["DesignationRank"].ToString();
                    srq.direct = ds.Tables[0].Rows[i]["Direct"].ToString();
                    srq.status = ds.Tables[0].Rows[i]["status"].ToString();
                    srq.TotalBusiness = ds.Tables[0].Rows[i]["TotalBusiness"].ToString();
                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }



        public user view( string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectimage");
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.type = ds.Tables[0].Rows[i]["type"].ToString();
                    srq.image = ds.Tables[0].Rows[i]["image"].ToString();
                   
                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }

        public user views(string connectionString)
        {
            user srq = new user();
            List<userlistModel> orderListO = new List<userlistModel>();
            List<userlistModel> orderListOs = new List<userlistModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proimage", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
               

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                                 
                    srq.latest1 = ds.Tables[0].Rows[0]["image"].ToString();
                    srq.latest11 = ds.Tables[0].Rows[0]["title"].ToString();
                    srq.latest2 = ds.Tables[1].Rows[0]["image"].ToString();
                    srq.latest21 = ds.Tables[1].Rows[0]["title"].ToString();
                    srq.latest3 = ds.Tables[2].Rows[0]["image"].ToString();
                    srq.latest31 = ds.Tables[2].Rows[0]["title"].ToString();
                    srq.latest4 = ds.Tables[3].Rows[0]["image"].ToString();
                    srq.latest41 = ds.Tables[3].Rows[0]["title"].ToString();
                    srq.event1 = ds.Tables[4].Rows[0]["image"].ToString();
                    srq.event2 = ds.Tables[5].Rows[0]["image"].ToString();
                    srq.event3 = ds.Tables[6].Rows[0]["image"].ToString();
                    srq.event4 = ds.Tables[7].Rows[0]["image"].ToString();
                    srq.event5 = ds.Tables[8].Rows[0]["image"].ToString();
                    srq.event6 = ds.Tables[9].Rows[0]["image"].ToString();
                    srq.vol1 = ds.Tables[10].Rows[0]["image"].ToString();
                    srq.vol2 = ds.Tables[11].Rows[0]["image"].ToString();
                    srq.vol3 = ds.Tables[12].Rows[0]["image"].ToString();
                    srq.blog1 = ds.Tables[13].Rows[0]["image"].ToString();
                    srq.blog2 = ds.Tables[14].Rows[0]["image"].ToString();
                    srq.RegDate = ds.Tables[16].Rows[0]["Total"].ToString();
                    srq.video = ds.Tables[17].Rows[0]["video"].ToString();
                    srq.Silver = ds.Tables[18].Rows[0]["Silver"].ToString();
                    srq.Gold = ds.Tables[18].Rows[0]["Gold"].ToString();
                    srq.Pearl = ds.Tables[18].Rows[0]["Pearl"].ToString();
                    srq.popup = ds.Tables[21].Rows[0]["popimg"].ToString();

                for (int i = 0; i < ds.Tables[19].Rows.Count; i++)
                {
                    userlistModel srqs = new userlistModel();
                  
                    srqs.image = ds.Tables[19].Rows[i]["image"].ToString();

                    orderListO.Add(srqs);
                }
                srq.reglist = orderListO;
                for (int i = 0; i < ds.Tables[20].Rows.Count; i++)
                {
                    userlistModel srqs = new userlistModel();

                    srqs.image = ds.Tables[20].Rows[i]["image"].ToString();

                    orderListOs.Add(srqs);
                }
                srq.reglists = orderListOs;

                return srq;
            }
        }
        public user levellist(string userid, string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proslevel", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
              //  cmd.Parameters.AddWithValue("@action", "Allbyuserid");
                cmd.Parameters.AddWithValue("@UserId", userid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["level"].ToString();
                    srq.TotalBusiness = ds.Tables[0].Rows[i]["tcount"].ToString();
                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }

        public user levellists(string userid, string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proslevels", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //  cmd.Parameters.AddWithValue("@action", "Allbyuserid");
                cmd.Parameters.AddWithValue("@UserId", userid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[i]["level"].ToString();
                    srq.TotalBusiness = ds.Tables[0].Rows[i]["tcount"].ToString();
                    orderListO.Add(srq);
                }
                tl.reglist = orderListO;

                return tl;
            }
        }

        public user sponsrd(string uid, string connectionString)
        {
            user tl = new user();

            List<userlistModel> noListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();

                //cmd.Parameters.AddWithValue("@action", "allUserpaymentsummary");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    userlistModel srq = new userlistModel();

                    srq.name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.emailaddress = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[i]["Sponsorid"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.City = ds.Tables[0].Rows[i]["City"].ToString();
                }
                con.Close();
            }
            tl.reglist = noListO;
            return tl;
        }

        public userlistModel userprofilesee( string uid ,string connectionString)
        {

            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

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
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[0]["Name"].ToString();
                    srq.emailaddress = ds.Tables[0].Rows[0]["Email"].ToString();
                    srq.Sponsorid = ds.Tables[0].Rows[0]["Sponsorid"].ToString();
                    srq.parentid = ds.Tables[0].Rows[0]["parentid"].ToString();
                srq.Sponsorname= ds.Tables[0].Rows[0]["Sponsorname"].ToString();
                srq.parentname = ds.Tables[0].Rows[0]["parentname"].ToString();
                srq.Mobile = ds.Tables[0].Rows[0]["Mobile"].ToString();
                    srq.userid = ds.Tables[0].Rows[0]["UserId"].ToString();
                    srq.package = ds.Tables[0].Rows[0]["Package"].ToString();
                    srq.date = ds.Tables[0].Rows[0]["ActiveDate"].ToString();
                    srq.password = ds.Tables[0].Rows[0]["Password"].ToString();
                    srq.City = ds.Tables[0].Rows[0]["City"].ToString();
                   srq.address = ds.Tables[0].Rows[0]["address"].ToString();
                   srq.image = ds.Tables[0].Rows[0]["photo"].ToString();
                   srq.accountno = ds.Tables[0].Rows[0]["AccountNo"].ToString();
                   srq.ActiveDate = ds.Tables[0].Rows[0]["ActiveDate"].ToString();
                   srq.pancard= ds.Tables[0].Rows[0]["PanNo"].ToString();
                   srq.nominee= ds.Tables[0].Rows[0]["nominee"].ToString();
                   srq.planename= ds.Tables[0].Rows[0]["planename"].ToString();
                return srq;
            }
        }

        public couponlist couponsee(string uid, string connectionString)
        {

            couponlist tl = new couponlist();

            List<couponwallet> orderListO = new List<couponwallet>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proCoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectcoupon");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    couponwallet srq = new couponwallet();
                    srq.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.couponid = ds.Tables[0].Rows[i]["couponid"].ToString();
                    srq.couponamount = ds.Tables[0].Rows[i]["couponamount"].ToString();
                    srq.createby = ds.Tables[0].Rows[i]["createby"].ToString();
                    srq.cdate = ds.Tables[0].Rows[i]["cdate"].ToString();
                    srq.edate = ds.Tables[0].Rows[i]["edatetime"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["inout"].ToString();
                    srq.transferto = ds.Tables[0].Rows[i]["transferto"].ToString();
                    srq.statuss = ds.Tables[0].Rows[i]["sstatus"].ToString();
                    srq.status = ds.Tables[0].Rows[i]["ustatus"].ToString();
                    orderListO.Add(srq);
                }
                tl.couponslist = orderListO;
                return tl;
            }
        }

       

        public couponlist couponsees( string connectionString)
        {

            couponlist tl = new couponlist();

            List<couponwallet> orderListO = new List<couponwallet>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proCoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectcouponadmin");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    couponwallet srq = new couponwallet();
                    srq.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.name = ds.Tables[0].Rows[i]["name"].ToString();
                    srq.couponid = ds.Tables[0].Rows[i]["couponid"].ToString();
                    srq.couponamount = ds.Tables[0].Rows[i]["couponamount"].ToString();
                    srq.createby = ds.Tables[0].Rows[i]["createby"].ToString();
                    srq.cdate = ds.Tables[0].Rows[i]["cdate"].ToString();
                    srq.inout = ds.Tables[0].Rows[i]["inout"].ToString();
                    srq.transferto = ds.Tables[0].Rows[i]["transferto"].ToString();
                    srq.status = ds.Tables[0].Rows[i]["sstatus"].ToString();
                    srq.tname = ds.Tables[0].Rows[i]["names"].ToString();
                    orderListO.Add(srq);
                }
                tl.couponslist = orderListO;
                return tl;
            }
        }


        public income adminincomesee( string uid,string connectionString)
        {
            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosdashboard", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("incometype", uid);
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
                    srq.NetAmount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.investedid = ds.Tables[0].Rows[i]["investid"].ToString();
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }

        public string adminupdatepass(userlistModel ip, string connectionString)
        {
            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "UpdatebyIDAdmin");
                cmd.Parameters.AddWithValue("@userid", ip.userid);
                cmd.Parameters.AddWithValue("@password", ip.password);
                cmd.Parameters.AddWithValue("@Name", ip.name);
                cmd.Parameters.AddWithValue("@Email", ip.emailaddress);
                cmd.Parameters.AddWithValue("@Mobile", ip.Mobile);
                cmd.Parameters.AddWithValue("@City", ip.City);
                cmd.Parameters.AddWithValue("@planename", ip.planename);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Password Changed";
            }
        }
        public userlistModel userupdatepass(userlistModel ip,string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@action", "Updatebyuser");
                //cmd.Parameters.AddWithValue("@password", ip.password);
                cmd.Parameters.AddWithValue("@Name", ip.name);
                cmd.Parameters.AddWithValue("@AccountNo", ip.accountno);
                cmd.Parameters.AddWithValue("@Mobile", ip.Mobile);
                cmd.Parameters.AddWithValue("@City", ip.City);
                cmd.Parameters.AddWithValue("@Email", ip.emailaddress);
                cmd.Parameters.AddWithValue("@address", ip.address);
                cmd.Parameters.AddWithValue("@nominee", ip.nominee);
                cmd.Parameters.AddWithValue("@Image", "../upload/" + ip.image);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                userlistModel pp = new userlistModel();
                pp.message = ds.Tables[0].Rows[0]["message"].ToString();
                return pp;
                
            }
        }


        public userlistModel userupdatepassword(userlistModel ip, string uid, string connectionString)
        {
            user tl = new user();

            List<userlistModel> orderListO = new List<userlistModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proUpdatepassword", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@OldPassword", ip.CurrentPassword);
                cmd.Parameters.AddWithValue("@NewPassword", ip.ConfirmPassword);
                cmd.Parameters.AddWithValue("@EntarePassword", ip.NewPassword);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                userlistModel pp = new userlistModel();
                pp.message = ds.Tables[0].Rows[0]["Messgae"].ToString();
                return pp;
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
       
        public string updatecoupon(string couponid, string byuserid, string uid, string connectionString)
        {

           

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("procoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "transfer");
                cmd.Parameters.AddWithValue("@transferto", byuserid);
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@couponid", couponid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "blocked";
            }
        }
        public string addcard(string id, string uid, string connectionString)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "card");
                cmd.Parameters.AddWithValue("@pid", id);
                cmd.Parameters.AddWithValue("@userid", uid);
              
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "blocked";
            }
        }

        public string delcard(string id, string uid, string connectionString)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "delcardlist");
                cmd.Parameters.AddWithValue("@indexid", id);
                cmd.Parameters.AddWithValue("@userid", uid);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "blocked";
            }
        }

        public userlistModel findadress(string uid,string connectionString)
        {

           

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "userlistfid");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
               
                    userlistModel srq = new userlistModel();
                    srq.name = ds.Tables[0].Rows[0]["Name"].ToString();
                   
                    srq.City = ds.Tables[0].Rows[0]["city1"].ToString();
                    srq.address = ds.Tables[0].Rows[0]["address"].ToString();
                    srq.pin = ds.Tables[0].Rows[0]["pincode"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[0]["Mobile"].ToString();
                    srq.state = ds.Tables[0].Rows[0]["State"].ToString();
                   
                   
                   
                return srq;
            }
        }

        public string updateaddress(string uid, userlistModel m, string connectionString)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "updateaddress");
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@city", m.City);
                cmd.Parameters.AddWithValue("@address", m.address);
                cmd.Parameters.AddWithValue("@pincode", m.pin);
                cmd.Parameters.AddWithValue("@state", m.state);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "blocked";
            }
        }

        public string upgradeid(string uid, string connectionString)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prolevelupgrade", con)
                {
                    CommandType = CommandType.StoredProcedure
                };


                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][0].ToString(); ;
            }
        }

        public string addsave(string uid, Rootes m, string connectionString)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proaddpost", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "save");
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@image",m.adimageurl);
                cmd.Parameters.AddWithValue("@post", m.adpost);
                cmd.Parameters.AddWithValue("@url", m.adurl);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "blocked";
            }
        }
        public Rootes fadd(string uid, string connectionString)
        {
            Rootes obm = new Rootes();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proaddpost", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "find");
                cmd.Parameters.AddWithValue("@userid", uid);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    obm.adpost = ds.Tables[1].Rows[0]["post"].ToString();
                    obm.adimage = ds.Tables[1].Rows[0]["image"].ToString();
                    obm.url = ds.Tables[1].Rows[0]["url"].ToString();
                    obm.adurl = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            return obm;
        }

        public string pop(string f, string connectionString)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insertpop");

                cmd.Parameters.AddWithValue("@img", "../upload/" + f);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "ok";
            }
        }


    }
}
