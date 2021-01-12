using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace scBridgelinkca.com.Models
{
    public class ContactUsModel
    {
        public string ContactName { get; set; }
        public string ContactEmail{ get; set; }
        public string ContactMessage { get; set; }
        public bool OptIn { get; set; }
        public string CurrentURL { get; set; }
    }
}