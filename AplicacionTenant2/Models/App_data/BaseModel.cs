using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace AplicacionTenant2.Models.App_data
{
    public partial class BaseModel
    {
        public Context Entity;

        public string serverName="LAPTOP-2GGF1CMS";
        public string user = Constant.user;
        public string password = Constant.password;
        public string databaseName;
       
        
        public BaseModel(string dataBase )
        {
   
            this.databaseName = dataBase;

            Entity = new Context("Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";Integrated Security=False;User Id="+user+";Password=" + password + ";MultipleActiveResultSets=True;Application Name=EntityFramework");
        }
    }
}