using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionTenant2.Models
{
    public class databaseInstances
    {
        public int id { get; set; }
        public int tenantId { get; set; }
        public int databaseType { get; set; }

        public string serverNameOrIP { get; set; }

        public string databaseName { get; set; }

        public string databaseUser { get; set; }

        public string databasePassword { get; set; }
    
}
}