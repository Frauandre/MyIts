namespace MVC_BikeStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prodution.Products")]
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Order_Items = new HashSet<Order_Items>();
            Stocks = new HashSet<Stocks>();
        }

        [Key]
        public int Product_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Product_Name { get; set; }

        public int Brand_Id { get; set; }

        public int Category_Id { get; set; }

        public short Model_Year { get; set; }

        public decimal List_Price { get; set; }

        public virtual Brands Brands { get; set; }

        public virtual Categories Categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Items> Order_Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stocks> Stocks { get; set; }
    }
}
