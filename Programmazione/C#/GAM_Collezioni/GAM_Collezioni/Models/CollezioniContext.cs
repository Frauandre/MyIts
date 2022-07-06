using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GAM_Collezioni.Models
{
    public class CollezioniContext:DbContext
    {
        public DbSet<Autore> Autori { get; set; }
        public DbSet<Mostra> Mostre { get; set; }

        public CollezioniContext()
        {
            Database.Connection.ConnectionString = 
                ConfigurationManager.ConnectionStrings["CollezioniConnection"].ConnectionString;
        }
    }
}