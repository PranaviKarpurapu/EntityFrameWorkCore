using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExOnDataAccessLayer.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }



        [Column(TypeName = "Date")]
        public DateTime? OrderDate { get; set; }
        
        
        [Column(TypeName = "Date")]
        public DateTime? DeliveryDate { get; set; }



        public int ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Item Items { get; set; }


    }
}
