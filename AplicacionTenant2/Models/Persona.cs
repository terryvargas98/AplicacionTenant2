using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AplicacionTenant2.Models
{
    [Table("Persona")]
    public class Persona
    {
      

        public int id { get; set; }
       public string name { get; set; }
    }
}