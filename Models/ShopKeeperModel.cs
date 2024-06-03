using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forex.Models
{
    public class ShopKeeperModel
    {
        public string name { get; set; }
        public string userid { get; set; }
        public string emailaddress { get; set; }
        public string password { get; set; }
        public string result { get; set; }
        public string address { get; set; }
        public string Sponsorid { get; set; }
        public string city { get; set; }
        public string Mobile { get; set; }
        public string Leg { get; set; }
        public string wallet { get; set; }
        public string rank { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public string message { get; set; }
    }
    public class shopReglist
    {
        public List<ShopKeeperModel> allShop { get; set; }
    }


    public class ProductAddModel
    {
        public string indexid { get; set; }
        public string dstatus { get; set; }
        public string pid { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string discount { get; set; }
        public string discription { get; set; }
        public string image { get; set; }
        public string walletamount { get; set; }
        public string userid { get; set; }
        public string username { get; set; }
        public string orderid { get; set; }
        public string date { get; set; }
        public string pname { get; set; }
        public string totalamount { get; set; }
        public string Address { get; set; }
        public string mobile { get; set; }

        public string totalprice { get; set; }
    }

    public class ProductAddModelList: ProductAddModel
    {
        public List<ProductAddModel> ProductAddModelVarriable { get; set; }
        public List<ProductAddModel> ProductAddModelVarriables { get; set; }
    }
    class Product
    {
        public string productId { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
    }


}
