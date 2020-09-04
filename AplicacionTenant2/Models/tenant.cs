using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionTenant2.Models
{
    public class tenant
    {
        public int id { get; set; }
        public string identityNumber { get; set; }
        public string name { get; set; }

        public string domain { get; set; }

        public string subdomain { get; set; }
    }
}