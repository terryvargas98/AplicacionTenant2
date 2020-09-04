using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using AplicacionTenant2.Models;
namespace AplicacionTenant2.Models
{
    public class Context : DbContext
    {

       
        public Context():
            base("name=Central")
        {

        }
        public Context(string conn)
: base(conn)
        {
        }


        public DbSet<Persona> Persona { get; set; }

        public DbSet<databaseInstances> databaseInstancia { get; set; }

        public DbSet<tenant> tenant { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

