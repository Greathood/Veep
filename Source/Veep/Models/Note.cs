using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veep.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string add_time { get; set; } 
        public string alarm_time { get; set; }
        public string category_id { get; set; } 
    }
}