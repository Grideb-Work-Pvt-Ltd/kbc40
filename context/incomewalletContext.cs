using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace forex.context
{
    public class incomewalletContext
    {
        public income incomeseedate(string id, string uid, string connectionString)
        {
            income tl = new income();
            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundwallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
              
                cmd.Parameters.AddWithValue("userid", uid);
                //cmd.Parameters.AddWithValue("userid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incomeModel srq = new incomeModel();
                    srq.Userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                      srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.InOut = ds.Tables[0].Rows[i]["InOut"].ToString();
                    // srq.Admin = ds.Tables[0].Rows[i]["Admin"].ToString();
                    srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.NetAmount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    //  srq.investedid = ds.Tables[0].Rows[i]["investid"].ToString();
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }


        public string insertimgs(string index, string img, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proslider", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "Insert");
                cmd.Parameters.AddWithValue("@indexid", index);
                cmd.Parameters.AddWithValue("@img", "../upload/" + img);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }

        public IncomeWallet slideimg(string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();
            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectpop");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
               
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();

                    srq.Index = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.img = ds.Tables[0].Rows[i]["popimg"].ToString();

                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                return tl;
            }
        }

        public IncomeWallet pdfimg(string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();
            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectpdf");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();

                    srq.Index = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.img = ds.Tables[0].Rows[i]["popimg"].ToString();

                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                return tl;
            }
        }


        public IncomeWallet slideimglogin(string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();
            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectpoplogin");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();

                    srq.Index = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.img = ds.Tables[0].Rows[i]["popimg"].ToString();

                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                return tl;
            }
        }

        public IncomeWallet slideimgdashboard(string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();
            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectpopdashboard");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();

                    srq.Index = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.img = ds.Tables[0].Rows[i]["popimg"].ToString();

                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                return tl;
            }
        }


        public income incomesee(string id, string uid,string connectionString)
        {
            income tl = new income();
            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proUserIncome", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "showbyuser");
                cmd.Parameters.AddWithValue("incometype", uid);
                cmd.Parameters.AddWithValue("userid", id);
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

        public income distributionsee( string connectionString)
        {
            income tl = new income();
            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscluddistributionname", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incomeModel srq = new incomeModel();
                    srq.Userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.bankname = ds.Tables[0].Rows[i]["sponsorid"].ToString();
                    srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.amount1 = ds.Tables[0].Rows[i]["amount"].ToString();
                    srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                   
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }

        public IncomeWallet couponlist(string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();
            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "select");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();

                    srq.value = ds.Tables[0].Rows[i]["value"].ToString();
                    srq.couponid = ds.Tables[0].Rows[i]["couponid"].ToString();
                    srq.type = ds.Tables[0].Rows[i]["type"].ToString();
                    srq.sdate = ds.Tables[0].Rows[i]["startdate"].ToString();
                    srq.edate = ds.Tables[0].Rows[i]["enddate"].ToString();
                    srq.exdate = ds.Tables[0].Rows[i]["expirydate"].ToString();
                    srq.Index = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.img = ds.Tables[0].Rows[i]["img"].ToString();

                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                return tl;
            }
        }

        public income incomesee( string connectionString)
        {
            income tl = new income();
            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proUserIncome", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "showall");
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


        public income annual(string connectionString)
        {
            income tl = new income();
            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proannual", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
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
                    srq.Name = ds.Tables[0].Rows[i]["name"].ToString();
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }


        public income totalincomelsee( string uid, string connectionString)
        {
            income tl = new income();
            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proUserIncome", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "showall");
                cmd.Parameters.AddWithValue("userid", uid);
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

        public couponlist bonanzasee( string connectionString)
        {
            couponlist tl = new couponlist();
            List<couponwallet> orderListO = new List<couponwallet>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("probonanza", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "select");
              
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    couponwallet srq = new couponwallet();
                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.startdate = ds.Tables[0].Rows[i]["startdate"].ToString();
                    srq.enddate = ds.Tables[0].Rows[i]["enddate"].ToString();
                    srq.rank = ds.Tables[0].Rows[i]["rank"].ToString();
                    srq.Direct = ds.Tables[0].Rows[i]["Direct"].ToString();
                    srq.hours = ds.Tables[0].Rows[i]["hours"].ToString();
                    srq.coupon = ds.Tables[0].Rows[i]["coupon"].ToString();
                    srq.price = ds.Tables[0].Rows[i]["price"].ToString();
                    orderListO.Add(srq);
                }
                tl.couponslist = orderListO;
                return tl;
            }
        }

        public couponlist bonanzasees(string connectionString)
        {
            couponlist tl = new couponlist();
            List<couponwallet> orderListO = new List<couponwallet>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("probonanza", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "select1");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    couponwallet srq = new couponwallet();
                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.startdate = ds.Tables[0].Rows[i]["startdate"].ToString();
                    srq.enddate = ds.Tables[0].Rows[i]["enddate"].ToString();
                    srq.rank = ds.Tables[0].Rows[i]["rank"].ToString();
                    srq.Direct = ds.Tables[0].Rows[i]["Direct"].ToString();
                    srq.hours = ds.Tables[0].Rows[i]["hours"].ToString();
                    srq.coupon = ds.Tables[0].Rows[i]["coupon"].ToString();
                    srq.price = ds.Tables[0].Rows[i]["price"].ToString();
                    orderListO.Add(srq);
                }
                tl.couponslist = orderListO;
                return tl;
            }
        }


        public string delsee(int id,string connectionString)
        {
           

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("probonanza", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "dels");
                cmd.Parameters.AddWithValue("@indexid", id);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
               
                return "done" ;
            }
        }

        public string insertuser(int id, string connectionString)
        {

           
            
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                for (int i = 0; i < id; i++)
                {
                    SqlCommand cmd = new SqlCommand("proregisters", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };


                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                }
                    return "done";
                }
            
        }


        public string upload(string type,string image, string connectionString)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "Uploadimage");
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@image", image);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                return "done";
            }
        }

        public string uploads(string type, string image, string title, string connectionString)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "Uploadimage");
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@title", title);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                return "done";
            }
        }


        public string uploadv(string url,string connectionString)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insertvideo");
                cmd.Parameters.AddWithValue("@userid", url);
             
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                return "done";
            }
        }

        public string delimgs(string index, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "delpop");
                cmd.Parameters.AddWithValue("@indexid", index);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }

        public string delpdf(string index, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "delpdf");
                cmd.Parameters.AddWithValue("@indexid", index);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }

        public string delimgslogin(string index, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "delpoplogin");
                cmd.Parameters.AddWithValue("@indexid", index);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }

        public string delimgsdashboard(string index, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "delpopdashboard");
                cmd.Parameters.AddWithValue("@indexid", index);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }




        public string delimg(string id,string connectionString)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "delimage");
               
                cmd.Parameters.AddWithValue("@indexid",id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                return "done";
            }
        }

        public couponwallet editesee(int id, string connectionString)
        {
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("probonanza", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "find");
                cmd.Parameters.AddWithValue("@indexid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                couponwallet srq = new couponwallet();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

                {
                    
                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.startdate = ds.Tables[0].Rows[i]["startdate"].ToString();
                    srq.enddate = ds.Tables[0].Rows[i]["enddate"].ToString();
                    srq.rank = ds.Tables[0].Rows[i]["rank"].ToString();
                    srq.Direct = ds.Tables[0].Rows[i]["Direct"].ToString();
                    srq.hours = ds.Tables[0].Rows[i]["hours"].ToString();
                    srq.coupon = ds.Tables[0].Rows[i]["coupon"].ToString();
                    srq.price = ds.Tables[0].Rows[i]["price"].ToString();
                   
                }
                 
                return srq;
            }
        }

        public incomeModel paySee(string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proUserIncome", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                cmd.Parameters.AddWithValue("@action", "showbyuser");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                incomeModel srq = new incomeModel();
                srq.Amount = ds.Tables[1].Rows[0]["Amount"].ToString();
                srq.amount1 = ds.Tables[2].Rows[0][0].ToString();
                return srq;
            }
        }

        public incomeModel kbcSee(string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("procharitysee", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                incomeModel srq = new incomeModel();
                srq.Amount = ds.Tables[0].Rows[0]["Amount"].ToString();
               
                return srq;
            }
        }
      
          
              
public income needanSee(string uid, string connectionString)
        {
    income tl = new income();

    List<incomeModel> orderListO = new List<incomeModel>();

    using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proneedansee", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();

                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                    for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
            {
                incomeModel srq = new incomeModel();
                srq.Userid = ds.Tables[1].Rows[i]["Userid"].ToString();
                srq.Name = ds.Tables[1].Rows[i]["name"].ToString();
                srq.mobile = ds.Tables[1].Rows[i]["mobile"].ToString();
               
                orderListO.Add(srq);
            }
            tl.incomelist = orderListO;
            tl.Amount = ds.Tables[0].Rows[0]["Amount"].ToString();
                return tl;

           
            }
        }

        public incomeModel franchisebalSee(string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("profranchisebalance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();

                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                incomeModel srq = new incomeModel();
                srq.Amount = ds.Tables[0].Rows[0][0].ToString();

                return srq;
            }
        }


        public incomeModel paySeeClub(string uid, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proUserIncome", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                cmd.Parameters.AddWithValue("@action", "Club");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                incomeModel srq = new incomeModel();
                srq.Amount = ds.Tables[1].Rows[0]["Amount"].ToString();
                srq.NetAmount = ds.Tables[2].Rows[0][0].ToString();
                srq.gold =  ds.Tables[1].Rows[0]["gold"].ToString();
                srq.pearl = ds.Tables[1].Rows[0]["pearl"].ToString();
                srq.toapz = ds.Tables[1].Rows[0]["topaz"].ToString();
                srq.diamond = ds.Tables[1].Rows[0]["topaz"].ToString();
                srq.nwf = ds.Tables[1].Rows[0]["topaz"].ToString();

                srq.goldd = ds.Tables[2].Rows[0]["gold"].ToString();
                srq.pearld = ds.Tables[2].Rows[0]["pearl"].ToString();
                srq.toapzd = ds.Tables[2].Rows[0]["topaz"].ToString();
                srq.diamondd = ds.Tables[2].Rows[0]["topaz"].ToString();
                srq.nwfd = ds.Tables[2].Rows[0]["topaz"].ToString();
                return srq;
            }
        }

        public string paymentReqin(float amount, string uid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proiPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("detail", "User");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][1].ToString();
            }
        }

        public string paymentReqinfranchise(float amount, string uid,string franchise, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proiPaymentRequestfranchise", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("detail", "User");
                cmd.Parameters.AddWithValue("@franchiseid", franchise);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][1].ToString();
            }
        }


        public couponwallet bonaza(couponwallet m, string connectionString)
        {
            couponwallet t = new couponwallet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("probonanza", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@startdate", m.startdate);
                cmd.Parameters.AddWithValue("@enddate", m.enddate);
                cmd.Parameters.AddWithValue("@rank", m.rank);
                cmd.Parameters.AddWithValue("@Direct", m.Direct);
                cmd.Parameters.AddWithValue("@hours", m.hours);
                cmd.Parameters.AddWithValue("@coupon", m.coupon);
                cmd.Parameters.AddWithValue("@price", m.price);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                t.mass= ds.Tables[0].Rows[0][0].ToString();
                return t;
            }
        }

        public couponwallet top(couponwallet m, string connectionString)
        {
            couponwallet t = new couponwallet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proiClubDistribution", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@FromDate", m.startdate);
                cmd.Parameters.AddWithValue("@ToDate", m.enddate);
                

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                t.mass = ds.Tables[0].Rows[0][0].ToString();
                return t;
            }
        }

        public couponwallet bonazas(couponwallet m, string connectionString)
        {
            couponwallet t = new couponwallet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("probonanzanew", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@startdate", m.startdate);
                cmd.Parameters.AddWithValue("@enddate", m.enddate);
                if(m.rank==null)
                {

                }
                else
                {
                    cmd.Parameters.AddWithValue("@rank", m.rank);
                }
               
                cmd.Parameters.AddWithValue("@Direct", m.Direct);
                cmd.Parameters.AddWithValue("@hours", m.hours);
                cmd.Parameters.AddWithValue("@coupon", m.coupon);
                cmd.Parameters.AddWithValue("@price", m.price);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                t.mass = ds.Tables[0].Rows[0][0].ToString();
                return t;
            }
        }


        public couponwallet addnewcoupon(couponwallet m, string connectionString)
        {
            couponwallet t = new couponwallet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("procouponwallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@userid", m.userid);
                cmd.Parameters.AddWithValue("@edate", m.enddate);
               
                cmd.Parameters.AddWithValue("@totalcoupon", m.coupon);
                cmd.Parameters.AddWithValue("@Couponamount", m.price);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                
                return t;
            }
        }

        public couponwallet updatebonaza(couponwallet m, string connectionString)
        {
            couponwallet t = new couponwallet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("probonanza", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "update");
                cmd.Parameters.AddWithValue("@indexid", m.indexid);
                cmd.Parameters.AddWithValue("@startdate", m.startdate);
                cmd.Parameters.AddWithValue("@enddate", m.enddate);
                cmd.Parameters.AddWithValue("@rank", m.rank);
                cmd.Parameters.AddWithValue("@Direct", m.Direct);
                cmd.Parameters.AddWithValue("@hours", m.hours);
                cmd.Parameters.AddWithValue("@coupon", m.coupon);
                cmd.Parameters.AddWithValue("@price", m.price);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                t.mass = ds.Tables[0].Rows[0][0].ToString();
                return t;
            }
        }

        public IncomeWallet wonlist(string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();
            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("procoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectcoupon");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.value = ds.Tables[0].Rows[i]["value"].ToString();
                    srq.type = ds.Tables[0].Rows[i]["type"].ToString();
                    srq.sdate = ds.Tables[0].Rows[i]["startdate"].ToString();
                    srq.edate = ds.Tables[0].Rows[i]["enddate"].ToString();
                    srq.exdate = ds.Tables[0].Rows[i]["expirydate"].ToString();
                    srq.Index = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["date"].ToString();
                    srq.couponid = ds.Tables[0].Rows[i]["couponid"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                return tl;
            }
        }


        public string fundReqin(float amount, string uid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("detail", "User");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }


        public string fundReqintransTogreen(float amount, string uid, string byuserid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundtransTogreen", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("ByUserid", byuserid);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("detail", "User");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][1].ToString(); 
            }
        }

        public string fundReqintransTokbctoneedan(float amount, string uid, string byuserid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundtransTokbcToneedan", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("ByUserid", byuserid);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("detail", "User");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][1].ToString();
            }
        }

        public string fundReqintransTofranchisetoneedan(float amount, string uid, string byuserid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundtransTofranchiseToneedan", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("ByUserid", byuserid);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("detail", "User");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][1].ToString();
            }
        }

        public string fundReqintransTokbc(float amount, string uid, string byuserid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundtransTokbc", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("ByUserid", byuserid);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("detail", "User");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][1].ToString();
            }
        }
        public string fundReqintransTcharity(float amount, string uid, string byuserid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundtransTocharity", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("ByUserid",uid);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("detail", "User");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][1].ToString();
            }
        }

        public string fundReqintrans2xw(float amount, string uid, string byuserid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundtransTo2Xwallet", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("ByUserid", uid);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("detail", "User");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows[0][1].ToString();
            }
        }


        public income adminincomesee(  string connectionString)
        {

            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "UnPaid");
                //cmd.Parameters.AddWithValue("incometype", uid);
                //cmd.Parameters.AddWithValue("userid", dirct);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incomeModel srq = new incomeModel();
                    srq.Userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    //srq.InOut = ds.Tables[0].Rows[i]["InOut"].ToString();
                    //srq.Admin = ds.Tables[0].Rows[i]["Admin"].ToString();
                    //srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    //srq.NetAmount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    //srq.investedid = ds.Tables[0].Rows[i]["investid"].ToString();
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }

        public income adminunpaidsee(string connectionString)
        {

            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "UnPaid");
                //cmd.Parameters.AddWithValue("incometype", uid);
                //cmd.Parameters.AddWithValue("userid", dirct);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incomeModel srq = new incomeModel();
                    srq.Userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.mobile = ds.Tables[0].Rows[i]["mobile"].ToString();
                    srq.contactid = ds.Tables[0].Rows[i]["contactid"].ToString();
                    srq.faccount = ds.Tables[0].Rows[i]["faccount"].ToString();
                    srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.AdminCharge = ds.Tables[0].Rows[i]["AdminCharge"].ToString();
                    srq.TDS = ds.Tables[0].Rows[i]["tds"].ToString();
                    srq.Amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.NetAmount = ds.Tables[0].Rows[i]["NetAmount"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["accountno"].ToString();
                    srq.ifsc = ds.Tables[0].Rows[i]["IFSC"].ToString();
                    srq.bankname = ds.Tables[0].Rows[i]["BankName"].ToString();
                    srq.branch = ds.Tables[0].Rows[i]["Branch"].ToString();
                    srq.pan = ds.Tables[0].Rows[i]["pancard"].ToString();
                    srq.panno = ds.Tables[0].Rows[i]["panno"].ToString();
                    // srq.PaymentMedium = ds.Tables[0].Rows[i]["PaymentMedium"].ToString();
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }

        public income adminunpaidfranchisesee(string connectionString)
        {

            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "franUnPaid");
                //cmd.Parameters.AddWithValue("incometype", uid);
                //cmd.Parameters.AddWithValue("userid", dirct);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incomeModel srq = new incomeModel();
                    srq.Userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.mobile = ds.Tables[0].Rows[i]["mobile"].ToString();
                    srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.AdminCharge = ds.Tables[0].Rows[i]["AdminCharge"].ToString();
                    srq.Amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.NetAmount = ds.Tables[0].Rows[i]["NetAmount"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["accountno"].ToString();
                    srq.ifsc = ds.Tables[0].Rows[i]["IFSC"].ToString();
                    srq.bankname = ds.Tables[0].Rows[i]["BankName"].ToString();
                    srq.branch = ds.Tables[0].Rows[i]["Branch"].ToString();
                    srq.franchiseid = ds.Tables[0].Rows[i]["franchiseid"].ToString();
                    // srq.PaymentMedium = ds.Tables[0].Rows[i]["PaymentMedium"].ToString();
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }

        public income userunpaidfranchisesee(string uid,string connectionString)
        {

            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "userfranUnPaid");
                cmd.Parameters.AddWithValue("@userid", uid);
                //cmd.Parameters.AddWithValue("userid", dirct);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incomeModel srq = new incomeModel();
                    srq.Userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                    srq.mobile = ds.Tables[0].Rows[i]["mobile"].ToString();
                    srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.AdminCharge = ds.Tables[0].Rows[i]["AdminCharge"].ToString();
                    srq.Amount = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.NetAmount = ds.Tables[0].Rows[i]["NetAmount"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["accountno"].ToString();
                    srq.ifsc = ds.Tables[0].Rows[i]["IFSC"].ToString();
                    srq.bankname = ds.Tables[0].Rows[i]["BankName"].ToString();
                    srq.branch = ds.Tables[0].Rows[i]["Branch"].ToString();
                    srq.franchiseid = ds.Tables[0].Rows[i]["franchiseid"].ToString();
                    // srq.PaymentMedium = ds.Tables[0].Rows[i]["PaymentMedium"].ToString();
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }


        public string withdrawlReqins(incomeModel it,int amount, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "update");
                cmd.Parameters.AddWithValue("UserId", it.indexid);
                cmd.Parameters.AddWithValue("Reason", it.Detail);
                cmd.Parameters.AddWithValue("amount", amount);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }

        public string withdrawlReqin(string amount, string indexid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "update");
                cmd.Parameters.AddWithValue("UserId", indexid);
                cmd.Parameters.AddWithValue("Reason", amount);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }

        public string withdrawlReqinfranchise(string amount, string indexid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "updatefranchise");
                cmd.Parameters.AddWithValue("UserId", indexid);
                cmd.Parameters.AddWithValue("Reason", amount);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }


        public string withdrawlReqin1(string indexid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "reject");
                cmd.Parameters.AddWithValue("UserId", indexid);
                cmd.Parameters.AddWithValue("Reason", "Rejected");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }

        public string withdrawlReqinfranchise1(string indexid, string connectionString)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "rejectfranchise");
                cmd.Parameters.AddWithValue("UserId", indexid);
                cmd.Parameters.AddWithValue("Reason", "Rejected");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "Amount";
            }
        }



        public income adminpaidsee(string connectionString)
        {

            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "Paid");
                //cmd.Parameters.AddWithValue("incometype", uid);
                //cmd.Parameters.AddWithValue("userid", dirct);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incomeModel srq = new incomeModel();
                    srq.Userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["name"].ToString();
                    srq.mobile = ds.Tables[0].Rows[i]["mobile"].ToString();
                    srq.bankname = ds.Tables[0].Rows[i]["bankname"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["accountno"].ToString();
                    srq.ifsc = ds.Tables[0].Rows[i]["ifsc"].ToString();
                    srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.AdminCharge = ds.Tables[0].Rows[i]["AdminCharge"].ToString();
                    srq.NetAmount = ds.Tables[0].Rows[i]["netamount"].ToString();
                    srq.TDS = ds.Tables[0].Rows[i]["TDS"].ToString();
                    srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.amount1 = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["accountno"].ToString();
                    srq.ifsc = ds.Tables[0].Rows[i]["IFSC"].ToString();
                    srq.bankname = ds.Tables[0].Rows[i]["BankName"].ToString();
                    srq.branch = ds.Tables[0].Rows[i]["Branch"].ToString();
                    srq.tstatus = ds.Tables[0].Rows[i]["tstatus"].ToString();
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }

        public income adminpaidseees(string connectionString)
        {

            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosPaymentRequest", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "Paidts");
                //cmd.Parameters.AddWithValue("incometype", uid);
                //cmd.Parameters.AddWithValue("userid", dirct);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    incomeModel srq = new incomeModel();
                    srq.Userid = ds.Tables[0].Rows[i]["Userid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["name"].ToString();
                    srq.mobile = ds.Tables[0].Rows[i]["mobile"].ToString();
                    srq.bankname = ds.Tables[0].Rows[i]["bankname"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["accountno"].ToString();
                    srq.ifsc = ds.Tables[0].Rows[i]["ifsc"].ToString();
                    srq.Detail = ds.Tables[0].Rows[i]["Detail"].ToString();
                    srq.AdminCharge = ds.Tables[0].Rows[i]["AdminCharge"].ToString();
                    srq.NetAmount = ds.Tables[0].Rows[i]["netamount"].ToString();
                    srq.TDS = ds.Tables[0].Rows[i]["TDS"].ToString();
                    srq.tDate = ds.Tables[0].Rows[i]["tDate"].ToString();
                    srq.amount1 = ds.Tables[0].Rows[i]["Amount"].ToString();
                    srq.accountno = ds.Tables[0].Rows[i]["accountno"].ToString();
                    srq.ifsc = ds.Tables[0].Rows[i]["IFSC"].ToString();
                    srq.bankname = ds.Tables[0].Rows[i]["BankName"].ToString();
                    srq.branch = ds.Tables[0].Rows[i]["Branch"].ToString();
                    srq.tstatus = ds.Tables[0].Rows[i]["tstatus"].ToString();
                    orderListO.Add(srq);
                }
                tl.incomelist = orderListO;
                return tl;
            }
        }
        public income royal(incomeModel incoO, string uid, string connectionString)
        {
            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proroyalitynew", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@fdate", incoO.pdate);
                cmd.Parameters.AddWithValue("@ldate", incoO.tDate);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return tl;
            }
        }
        public income royalitysee(string connectionString)
        {

            income tl = new income();

            List<incomeModel> orderListO = new List<incomeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("royalitysummary", con)
                {
                    CommandType = CommandType.StoredProcedure
                };               
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

        public incomeModel greenwalletsee(string uid, string connectionString)
        {
            incomeModel tl = new incomeModel();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosfundRequesttopup", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "selectone");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                tl.tamount = ds.Tables[0].Rows[0][0].ToString();
                return tl;
            }
        }

        public incomeModel greenfundReqin(float amount, string useridgreen, string uid,string wallet, string connectionString)
        {
            incomeModel tl = new incomeModel();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proifundgreentogreen", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("Userid", uid);
                cmd.Parameters.AddWithValue("@byuserid", uid);
                cmd.Parameters.AddWithValue("@wallet", wallet);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                tl.tamount = ds.Tables[0].Rows[0][0].ToString();
                return tl;
            }
        }

        public IncomeWallet userwonlist(string uid, string connectionString)
        {
            IncomeWallet tl = new IncomeWallet();
            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectusercoupon");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    srq.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.value = ds.Tables[0].Rows[i]["value"].ToString();
                    srq.type = ds.Tables[0].Rows[i]["type"].ToString();
                    srq.sdate = ds.Tables[0].Rows[i]["startdate"].ToString();
                    srq.edate = ds.Tables[0].Rows[i]["enddate"].ToString();
                    srq.exdate = ds.Tables[0].Rows[i]["expirydate"].ToString();
                    srq.Index = ds.Tables[0].Rows[i]["indexid"].ToString();
                    srq.Date = ds.Tables[0].Rows[i]["date"].ToString();
                    srq.img = ds.Tables[0].Rows[i]["img"].ToString();
                    srq.status = ds.Tables[0].Rows[i]["status"].ToString();

                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;
                return tl;
            }
        }

        public walletmodel userwonlists(string id, string connectionString)
        {


            walletmodel srq = new walletmodel();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proscrchcoupon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "selectusercoupons");
                cmd.Parameters.AddWithValue("@userid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                srq.couponid = ds.Tables[0].Rows[0]["couponid"].ToString();
                srq.userid = ds.Tables[0].Rows[0]["userid"].ToString();
                srq.value = ds.Tables[0].Rows[0]["value"].ToString();
                srq.type = ds.Tables[0].Rows[0]["type"].ToString();
                srq.sdate = ds.Tables[0].Rows[0]["startdate"].ToString();
                srq.edate = ds.Tables[0].Rows[0]["enddate"].ToString();
                srq.exdate = ds.Tables[0].Rows[0]["expirydate"].ToString();
                srq.Index = ds.Tables[0].Rows[0]["indexid"].ToString();
                srq.Date = ds.Tables[0].Rows[0]["date"].ToString();
                srq.img = ds.Tables[0].Rows[0]["img"].ToString();
                srq.status = ds.Tables[0].Rows[0]["status"].ToString();


            }

            return srq;
        }


    }
}
