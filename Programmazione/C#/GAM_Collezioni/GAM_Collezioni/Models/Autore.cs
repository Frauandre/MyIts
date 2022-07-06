using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GAM_Collezioni.Models
{
    [Table("Autori")]
    public class Autore
    {
        public int Id { get; set; }
        public string Nominativo { get; set; }
    }
}