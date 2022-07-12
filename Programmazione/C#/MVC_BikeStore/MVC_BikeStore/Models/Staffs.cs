namespace MVC_BikeStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.Staffs")]
    public partial class Staffs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staffs()
        {
            Orders = new HashSet<Orders>();
            Staffs1 = new HashSet<Staffs>();
        }

        [Key]
        public int Staff_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        public byte Active { get; set; }

        public int Store_Id { get; set; }

        public int? Manager_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staffs> Staffs1 { get; set; }

        public virtual Staffs Staffs2 { get; set; }

        public virtual Stores Stores { get; set; }
    }
}
