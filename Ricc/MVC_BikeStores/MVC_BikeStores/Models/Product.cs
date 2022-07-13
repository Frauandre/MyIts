namespace MVC_BikeStores.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prodution.Products")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Order_Items = new HashSet<Order_Items>();
            Stocks = new HashSet<Stock>();
        }

        [Key]
        public int Product_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Product_Name { get; set; }

        public int Brand_Id { get; set; }

        public int Category_Id { get; set; }

        public short Model_Year { get; set; }

        [DataType(DataType.Currency)]
        public decimal List_Price { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Items> Order_Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
