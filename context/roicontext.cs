using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace forex.context
{
    public class roicontext
    {

        public roimodel roisee(string FromDate,string ToDate, string connectionString)
        {

            roimodel orderListO = new roimodel() ;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proiClubDistribution", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@FromDate", FromDate);
                cmd.Parameters.AddWithValue("@ToDate", ToDate);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                orderListO.message = ds.Tables[0].Rows[0][0].ToString();
                return orderListO;
            }
        }
    } 
}