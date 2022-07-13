namespace MVC_BikeStores.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.Order_Items")]
    public partial class Order_Items
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_Id { get; set; }

        public int Product_Id { get; set; }

        public int Quantity { get; set; }

        public decimal List_Price { get; set; }

        public decimal Discount { get; set; }

        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }
    }
}
