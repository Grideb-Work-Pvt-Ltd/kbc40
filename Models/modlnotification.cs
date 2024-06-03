

using System.Collections.Generic;

namespace forex.Models
{
    public class modlnotification
    {
        public string username { get; set; }
        public string userid { get; set; }
        public string city{ get; set; }
        public string Heading { get; set; }
        public string date { get; set; }
        public string Content { get; set; }
        public string reply { get; set; }
        public string replydate { get; set; }

        public string ticketid { get; set; }
        public string image { get; set; }
        public string delete { get; set; }


    }
    public class notifee
    {
        public List<modlnotification> notitotal { get; set; }
    }
}
