using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GAM_Collezioni.Models
{
    [Table("Mostre")]
    public class Mostra
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Datazione { get; set; }
        public string Tecnica { get; set; }
        public string Dimensioni { get; set; }
        public string Immagine { get; set; }
        public Autore Autore { get; set; }

    }
}