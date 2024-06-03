using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace forex.Models
{
    public class ShopKeeperContext
    {
        public ProductAddModelList ListData(string connectionstring)
        {
            ProductAddModelList li = new ProductAddModelList();

            List<ProductAddModel> ArryListObj = new List<ProductAddModel>();
           
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Action", "Select");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProductAddModel mod = new ProductAddModel();
                    mod.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    mod.pid = ds.Tables[0].Rows[i]["pid"].ToString();
                    mod.name = ds.Tables[0].Rows[i]["ProductName"].ToString();
                    mod.price = ds.Tables[0].Rows[i]["ProductPrice"].ToString();
                    mod.discription = ds.Tables[0].Rows[i]["ProductDescription"].ToString();
                    mod.quantity = ds.Tables[0].Rows[i]["ProductQuantity"].ToString();
                    mod.image = ds.Tables[0].Rows[i]["ProductImage"].ToString();
                    mod.discount = ds.Tables[0].Rows[i]["Discount"].ToString();
                    Double dbj = Convert.ToDouble(mod.price)+ Convert.ToDouble(mod.discount);
                    mod.walletamount = dbj.ToString();
                    ArryListObj.Add(mod);
                }
                li.ProductAddModelVarriable = ArryListObj;
                return li;
            }
        }
        public string ProductAddInsert(ProductAddModel logo, string connectionString)
        {
            string message = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Action", "Insert");
                cmd.Parameters.AddWithValue("@ProductName", logo.name);
                cmd.Parameters.AddWithValue("@ProductPrice", logo.price);
                cmd.Parameters.AddWithValue("@ProductDescription", logo.discription);
                cmd.Parameters.AddWithValue("@ProductImage", "../upload/" + logo.image);
                cmd.Parameters.AddWithValue("@ProductQuantity", logo.quantity);
                cmd.Parameters.AddWithValue("@Discount", logo.discount);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    message = "Product is successfuly inserted";
                }
                else
                {
                    message = "Product is not inserted !";
                }
            }
            return message;
        }
        public ProductAddModelList cardlist(string uid,string connectionstring)
        {
            ProductAddModelList li = new ProductAddModelList();

            List<ProductAddModel> ArryListObj = new List<ProductAddModel>();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Action", "cardlist");
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProductAddModel mod = new ProductAddModel();
                   
                    mod.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    mod.pid = ds.Tables[0].Rows[i]["pid"].ToString();
                    mod.name = ds.Tables[0].Rows[i]["ProductName"].ToString();
                    mod.price = ds.Tables[0].Rows[i]["ProductPrice"].ToString();
                   
                    mod.quantity = "1";
                    mod.image = ds.Tables[0].Rows[i]["ProductImage"].ToString();
                   
                    ArryListObj.Add(mod);
                }
                li.ProductAddModelVarriable = ArryListObj;
                return li;
            }
        }
        public string buypro(string uid, string products, string finalTotal, string connectionString)
        {
            string message = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proproductbuy", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
               

                // Deserialize the JSON array
                var nestedData = JsonConvert.DeserializeObject<Product[]>(products);

                // Create a DataTable
                DataTable dt = new DataTable();

                // Add columns to the DataTable
                dt.Columns.Add("productId");
                dt.Columns.Add("quantity");
                dt.Columns.Add("price");

                // Add data rows to the DataTable
                foreach (var product in nestedData)
                {
                    DataRow newRow = dt.NewRow();
                    newRow["productId"] = product.productId;
                    newRow["quantity"] = product.quantity;
                    newRow["price"] = product.price;
                    dt.Rows.Add(newRow);
                }
                cmd.Parameters.AddWithValue("@product", dt);
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@famount", finalTotal);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    message = "Product is successfuly Purchase";
                }
                else
                {
                    message = "Low Balance !";
                }
            }
            return message;
        }

        public ProductAddModelList orderlist(string connectionstring)
        {
            ProductAddModelList li = new ProductAddModelList();

            List<ProductAddModel> ArryListObj = new List<ProductAddModel>();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Action", "order");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProductAddModel mod = new ProductAddModel();
                    mod.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    mod.orderid = ds.Tables[0].Rows[i]["orderid"].ToString();
                    mod.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    mod.name = ds.Tables[0].Rows[i]["name"].ToString();
                    mod.date = ds.Tables[0].Rows[i]["date"].ToString();
                   
                    mod.price = ds.Tables[0].Rows[i]["totalprice"].ToString();
                    mod.dstatus = ds.Tables[0].Rows[i]["dstatus"].ToString();
                   
                    ArryListObj.Add(mod);
                }
                li.ProductAddModelVarriable = ArryListObj;
                return li;
            }
        }

        public ProductAddModelList orderlists(string uid,string connectionstring)
        {
            ProductAddModelList li = new ProductAddModelList();

            List<ProductAddModel> ArryListObj = new List<ProductAddModel>();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Action", "orders");
                cmd.Parameters.AddWithValue("@userid",uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProductAddModel mod = new ProductAddModel();
                    mod.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    mod.orderid = ds.Tables[0].Rows[i]["orderid"].ToString();
                    mod.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    mod.name = ds.Tables[0].Rows[i]["name"].ToString();
                    mod.date = ds.Tables[0].Rows[i]["date"].ToString();

                    mod.price = ds.Tables[0].Rows[i]["totalprice"].ToString();


                    ArryListObj.Add(mod);
                }
                li.ProductAddModelVarriable = ArryListObj;
                return li;
            }
        }


        public ProductAddModelList allorderlist( string id,string connectionstring)
        {
            ProductAddModelList li = new ProductAddModelList();

            List<ProductAddModel> ArryListObj = new List<ProductAddModel>();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Action", "totalorder");
                cmd.Parameters.AddWithValue("@orderid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProductAddModel mod = new ProductAddModel();
                    mod.indexid = ds.Tables[0].Rows[i]["indexid"].ToString();
                    mod.orderid = ds.Tables[0].Rows[i]["orderid"].ToString();
                    mod.pid = ds.Tables[0].Rows[i]["pid"].ToString();
                    mod.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    mod.name = ds.Tables[0].Rows[i]["productname"].ToString();
                    mod.quantity = ds.Tables[0].Rows[i]["quantity"].ToString();

                    mod.price = ds.Tables[0].Rows[i]["price"].ToString();


                    ArryListObj.Add(mod);
                }
                li.ProductAddModelVarriable = ArryListObj;
                return li;
            }
        }
        public ProductAddModelList allorderlists(string id, string connectionstring)
        {
            ProductAddModelList li = new ProductAddModelList();

            List<ProductAddModel> ArryListObj = new List<ProductAddModel>();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("proProductAdd", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Action", "totalorders");
                cmd.Parameters.AddWithValue("@orderid", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                li.username = ds.Tables[1].Rows[0]["name"].ToString();
                li.totalamount = ds.Tables[1].Rows[0]["totalprice"].ToString();
                li.indexid= ds.Tables[1].Rows[0]["indexid"].ToString();
                li.mobile= ds.Tables[1].Rows[0]["mobile"].ToString();
                li.Address= ds.Tables[1].Rows[0]["Address"].ToString();
                li.date= ds.Tables[1].Rows[0]["date"].ToString();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProductAddModel mod = new ProductAddModel();
                    
                    mod.orderid = ds.Tables[0].Rows[i]["orderid"].ToString();
                    mod.pid = ds.Tables[0].Rows[i]["pid"].ToString();
                    mod.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                    mod.pname = ds.Tables[0].Rows[i]["productname"].ToString();
                    mod.quantity = ds.Tables[0].Rows[i]["quantity"].ToString();

                    mod.price = ds.Tables[0].Rows[i]["productprice"].ToString();
                    mod.totalprice = ds.Tables[0].Rows[i]["price"].ToString();


                    ArryListObj.Add(mod);
                }
                li.ProductAddModelVarriable = ArryListObj;
                return li;
            }
        }

    }
}
