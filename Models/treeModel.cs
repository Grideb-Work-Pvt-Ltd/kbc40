using System.Collections.Generic;

namespace forex.Models
{
    public class treeModel
    {
            public string Userid { get; set; }
            public string Name { get; set; }
            public string parentid { get; set; }
            public string ParentName { get; set; }
            public string ActiveDate { get; set; }
            public string RegDate { get; set; }
            public string Email { get; set; }
            public string Mobile { get; set; }
            public string TotalBusiness { get; set; }
            public string Package { get; set; }
            public string Leg { get; set; }
            public string level { get; set; }
        public string selfbv { get; set; }
            public string tStatus { get; set; }
            public string TotalBV { get; set; }
            public string Designation { get; set; }
            public string bv { get; set; }
        public string plann { get; set; }
        public string Sponsorid { get; set; }
        public string img { get; set; }



        public string c1 { get; set; }
        public string c2 { get; set; }
        public string c3 { get; set; }
        public string RankName { get; set; }
        public string Rank { get; set; }
    }
        public class treelist
        {
            public IEnumerable<treeModel> treelistobj { get; set; }
             public string totalteam { get; set; }
        public string TotalBusiness { get; set; }

        public string mobile { get; set; }
        public string name { get; set; }



    }


    public class TreeView
    {
        public string span1 { get; set; }
        public string span2 { get; set; }
        public string span3 { get; set; }
        public string span4 { get; set; }
        public string span5 { get; set; }
        public string span6 { get; set; }
        public string span7 { get; set; }
        public string span8 { get; set; }
        public string span9 { get; set; }
        public string span10 { get; set; }
        public string span11 { get; set; }
        public string span12 { get; set; }
        public string span13 { get; set; }
        public string span14 { get; set; }
        public string span15 { get; set; }

        public string span1id { get; set; }
        public string span2id { get; set; }
        public string span3id { get; set; }
        public string span4id { get; set; }
        public string span5id { get; set; }
        public string span6id { get; set; }
        public string span7id { get; set; }
        public string span8id { get; set; }
        public string span9id { get; set; }
        public string span10id { get; set; }
        public string span11id { get; set; }
        public string span12id { get; set; }
        public string span13id { get; set; }
        public string span14id { get; set; }
        public string span15id { get; set; }

        //...............................
        public string data1id { get; set; }
        public string data2id { get; set; }
        public string data3id { get; set; }
        public string data4id { get; set; }
        public string data5id { get; set; }
        public string data6id { get; set; }
        public string data7id { get; set; }
        public string data8id { get; set; }
        public string data9id { get; set; }
        public string data10id { get; set; }
        public string data11id { get; set; }
        public string data12id { get; set; }
        public string data13id { get; set; }
        public string data14id { get; set; }
        public string data15id { get; set; }

        //----------------------
        public string name1id { get; set; }
        public string name2id { get; set; }
        public string name3id { get; set; }
        public string name4id { get; set; }
        public string name5id { get; set; }
        public string name6id { get; set; }
        public string name7id { get; set; }
        public string name8id { get; set; }
        public string name9id { get; set; }
        public string name10id { get; set; }
        public string name11id { get; set; }
        public string name12id { get; set; }
        public string name13id { get; set; }
        public string name14id { get; set; }
        public string name15id { get; set; }
    }

    public class Income
    {
        public string byuserid { get; set; }
        public string userid { get; set; }
        public string username { get; set; }
        public string package { get; set; }
        public string details { get; set; }
        public string amount { get; set; }
        public string inout { get; set; }

    }

    public class IncoeWallet : Income
    {
        public IEnumerable<Income> Incomewall { get; set; }
    }

    public class Dashboard : dashbaordfront
    {
        public string name { get; set; }
        public string uid { get; set; }
        public string mobile { get; set; }
        public string Email { get; set; }
        public string location { get; set; }
        public string package { get; set; }
        public string designation { get; set; }
        public string sponsorid { get; set; }
        //public DateTime joindate { get; set; }
        //public DateTime regdate { get; set; }
        public string referal { get; set; }
        public string totalamount { get; set; }
        public string directamount { get; set; }
        public string pimg { get; set; }
        public string simg { get; set; }
        public string matchingamount { get; set; }

        public string rentalamount { get; set; }

        public string direct { get; set; }
        public string pdirect { get; set; }
        public string udirect { get; set; }

        public List<dashbaordfront> dashboards = new List<dashbaordfront>();
    }

    public class dashbaordfront : TreeView
    {

        public string name { get; set; }
        public string uid { get; set; }
        public string mobile { get; set; }
        public string Email { get; set; }
        public string location { get; set; }
        public string package { get; set; }
        public string designation { get; set; }
        public string sponsorid { get; set; }
        //public DateTime joindate { get; set; }
        //public DateTime regdate { get; set; }
        public string referal { get; set; }
        public string totalamount { get; set; }
        public string directamount { get; set; }
        public string pimg { get; set; }
        public string simg { get; set; }
        public string matchingamount { get; set; }

        public string rentalamount { get; set; }

        public string direct { get; set; }
        public string pdirect { get; set; }
        public string udirect { get; set; }
        public string title { get; set; }
        public string notification { get; set; }
        //public DateTime tdate { get; set; }
    }
}
