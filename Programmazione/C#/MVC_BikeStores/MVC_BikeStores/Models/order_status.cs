//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_BikeStores.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order_status()
        {
            this.orders = new HashSet<orders>();
        }
    
        public byte status_id { get; set; }
        public string status_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }
    }
}
