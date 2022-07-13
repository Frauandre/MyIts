namespace MVC_BikeStores.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.Customers")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int Customer_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Last_Name { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Street { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(25)]
        public string State { get; set; }

        [StringLength(5)]
        public string Zip_Code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
