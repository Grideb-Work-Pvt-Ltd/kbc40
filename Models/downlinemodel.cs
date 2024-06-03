using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forex.Models
{
    
        public class downlineModel
        {
            public string UserID { get; set; }
            public string Name { get; set; }
            public string Mobile { get; set; }
            public string Leg { get; set; }
            public string Package { get; set; }
            public string RegDate { get; set; }
        public string activedate { get; set; }
        public string sponsorid { get; set; }
        public string totalbv { get; set; }
        public string designation { get; set; }
        public string activestatus { get; set; }

        public string level { get; set; }
        public string Team { get; set; }
        public string RankName { get; set; }
        public string tcount { get; set; }
        public string requiredteam { get; set; }
        public string Rankbonus { get; set; }
        public string Email { get; set; }
        public string TotalBusiness { get; set; }
        public string ActiveDate { get; set; }
    }

        public class Downline : downlineModel
        {
            public IEnumerable<downlineModel> downlineparameters { get; set; }
        }

    }

