using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace forex.context
{
    public class adminnotification
    {
        public string notice(modlnotification notifimodel, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proNotification", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@userid", notifimodel.userid);
                cmd.Parameters.AddWithValue("@Title", notifimodel.Heading);
                cmd.Parameters.AddWithValue("@Notification", notifimodel.Content);
                cmd.Parameters.AddWithValue("@tDate", notifimodel.date);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";
            }
        }
        public notifee noticesee(string uid,string connectionString)
        {

            notifee tl = new notifee();

            List<modlnotification> noListO = new List<modlnotification>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proNotification", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "select");
                //cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    modlnotification srq = new modlnotification();

                    srq.Heading = ds.Tables[0].Rows[i]["Title"].ToString();
                    srq.Content = ds.Tables[0].Rows[i]["Notification"].ToString();
                    srq.date = ds.Tables[0].Rows[i]["tDate"].ToString();
                    noListO.Add(srq);
                }
                tl.notitotal = noListO;
                return tl;
            }
        }

        public string feedbac(modlnotification feed, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("profeedback", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@username", feed.username);
                cmd.Parameters.AddWithValue("@userid", feed.userid);
                cmd.Parameters.AddWithValue("@feedback", feed.Content);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "ok";
            }
        }


        public notifee feedsee(string connectionString)
        {

            notifee tl = new notifee();

            List<modlnotification> noListO = new List<modlnotification>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("profeedback", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "select");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    modlnotification srq = new modlnotification();

                    srq.username = ds.Tables[0].Rows[i]["username"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.Content = ds.Tables[0].Rows[i]["feedback"].ToString();
                    noListO.Add(srq);
                }
                tl.notitotal = noListO;

                return tl;
            }
        }

        public notifee feedseeuser(string userid, string connectionString)
        {

            notifee tl = new notifee();

            List<modlnotification> noListO = new List<modlnotification>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("profeedback", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@action", "selectuserid");
                cmd.Parameters.AddWithValue("@userid", userid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    modlnotification srq = new modlnotification();

                    srq.username = ds.Tables[0].Rows[i]["username"].ToString();
                    srq.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.Content = ds.Tables[0].Rows[i]["feedback"].ToString();
                    srq.reply = ds.Tables[0].Rows[i]["reply"].ToString();
                    srq.replydate = ds.Tables[0].Rows[i]["rdate"].ToString();
                    srq.ticketid = ds.Tables[0].Rows[i]["indexid"].ToString();


                    noListO.Add(srq);
                }
                tl.notitotal = noListO;

                return tl;
            }
        }


        public string Adminpop(modlnotification logo, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propopover", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@image", "../upload/" + logo.image);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";

            }
        }

        public string adminpopdelet(modlnotification lp, string connectionString)
        {
            modlnotification obm = new modlnotification();
            List<modlnotification> studentList = new List<modlnotification>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("propopover", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "delete");
                //cmd.Parameters.AddWithValue("@indexid", lp.delete);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";

            }
        }
        public string pimgdel(modlnotification lp, string connectionString)
        {
            modlnotification obm = new modlnotification();
            List<modlnotification> studentList = new List<modlnotification>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "delete");
                cmd.Parameters.AddWithValue("@indexid", lp.delete);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return "done";

            }
        }
    }
}
