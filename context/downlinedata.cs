using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace forex.context
{
    public class downlinedata
    {
        public Downline downlinesee(string uid,string connectionString)
        {

            Downline tl = new Downline();

            List<downlineModel> orderListO = new List<downlineModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "downline");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    downlineModel srq = new downlineModel();
                    srq.designation = ds.Tables[0].Rows[i]["Designation"].ToString();
                    srq.UserID = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["name"].ToString();
                    srq.Email = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.sponsorid = ds.Tables[0].Rows[i]["sponsorid"].ToString();
                    srq.ActiveDate = ds.Tables[0].Rows[i]["ActiveDate"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();
                    srq.activestatus= ds.Tables[0].Rows[i]["ActiveStatus"].ToString();
                    srq.TotalBusiness= ds.Tables[0].Rows[i]["TotalBusiness"].ToString();
                    srq.level = ds.Tables[0].Rows[i]["Employeelevel"].ToString();
                    srq.Package = ds.Tables[0].Rows[i]["package"].ToString();
                    orderListO.Add(srq);
                }
                tl.downlineparameters = orderListO;
                return tl;
            }
        }

        public Downline levelsee(string uid,string id, string connectionString)
        {

            Downline tl = new Downline();

            List<downlineModel> orderListO = new List<downlineModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prolevel", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "level");
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@level", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    downlineModel srq = new downlineModel();
                   // srq.designation = ds.Tables[0].Rows[i]["Designation"].ToString();
                    srq.UserID = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["name"].ToString();
                   // srq.Email = ds.Tables[0].Rows[i]["Email"].ToString();
                    srq.tcount = ds.Tables[0].Rows[i]["total"].ToString();
                    srq.sponsorid = ds.Tables[0].Rows[i]["sponsorid"].ToString();
                    srq.ActiveDate = ds.Tables[0].Rows[i]["ActiveDate"].ToString();
                    srq.RegDate = ds.Tables[0].Rows[i]["RegDate"].ToString();
                    //srq.activestatus = ds.Tables[0].Rows[i]["ActiveStatus"].ToString();
                    //srq.TotalBusiness = ds.Tables[0].Rows[i]["TotalBusiness"].ToString();
                    //srq.level = ds.Tables[0].Rows[i]["Employeelevel"].ToString();
                    //srq.Package = ds.Tables[0].Rows[i]["package"].ToString();
                    orderListO.Add(srq);
                }
                tl.downlineparameters = orderListO;
                return tl;
            }
        }

        public Downline matrixsee(string uid, string connectionString)
        {

            Downline tl = new Downline();

            List<downlineModel> orderListO = new List<downlineModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("matrixrank", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@action", "matrix");
                cmd.Parameters.AddWithValue("userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    downlineModel srq = new downlineModel();
                    srq.level = ds.Tables[0].Rows[i]["level"].ToString();
                    srq.Team = ds.Tables[0].Rows[i]["Team"].ToString();
                    srq.RankName = ds.Tables[0].Rows[i]["RankName"].ToString();
                    srq.tcount = ds.Tables[0].Rows[i]["tcount"].ToString();
                    srq.requiredteam = ds.Tables[0].Rows[i]["requiredteam"].ToString();
                    srq.Rankbonus = ds.Tables[0].Rows[i]["Rankbonus"].ToString();
                    orderListO.Add(srq);
                }
                tl.downlineparameters = orderListO;
                return tl;
            }
        }


        public Downline downlineadminsee(string uid ,string connectionString)
        {

            Downline tl = new Downline();

            List<downlineModel> orderListO = new List<downlineModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "downline");
                cmd.Parameters.AddWithValue("UserId", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    downlineModel srq = new downlineModel();
                    srq.UserID = ds.Tables[0].Rows[i]["userid"].ToString();
                    srq.Name = ds.Tables[0].Rows[i]["name"].ToString();
                    srq.Mobile = ds.Tables[0].Rows[i]["Mobile"].ToString();
                    srq.sponsorid = ds.Tables[0].Rows[i]["sponsorid"].ToString();
                    //srq.Regdate = ds.Tables[0].Rows[i]["Regdate"].ToString();
                    srq.designation = ds.Tables[0].Rows[i]["Designation"].ToString();
                    srq.activestatus = ds.Tables[0].Rows[i]["activestatus"].ToString();
                    srq.Leg = ds.Tables[0].Rows[i]["Leg"].ToString();
                    srq.totalbv = ds.Tables[0].Rows[i]["totalbv"].ToString();
                    srq.Package = ds.Tables[0].Rows[i]["package"].ToString();
                    orderListO.Add(srq);
                }
                tl.downlineparameters = orderListO;
                return tl;
            }
        }
    }
}
