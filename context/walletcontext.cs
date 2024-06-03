using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace forex.context
{
    public class walletcontext
    {
        public IncomeWallet walletsee(string connectionString)
        {

            IncomeWallet tl = new IncomeWallet();

            List<walletmodel> orderListO = new List<walletmodel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prosUserInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@action", "referral");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    walletmodel srq = new walletmodel();
                    //srq.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    //srq.transID = ds.Tables[0].Rows[i]["TransId"].ToString();
                    //srq.billno = ds.Tables[0].Rows[i]["BillNo"].ToString();
                    //srq.senderID = ds.Tables[0].Rows[i]["SenderId"].ToString();
                    orderListO.Add(srq);
                }
                tl.Incomewall = orderListO;

                return tl;
            }
        }
    }
}
