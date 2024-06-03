using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forex.Models
{
    public class roimodel
    {

        public string RegDate { get; set; }
        public string message { get; set; }
    }

    public class roilist
    {
        public List<roimodel> roitotal { get; set; }
    }
}

