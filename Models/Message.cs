using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Le_Messageur.Models
{
    public class Message
    {
        public Int64 MessageID { get; set; }
        public string message { get; set; }
        public string user { get; set; }
        public DateTime date_envoi { get; set; }
    }
}
