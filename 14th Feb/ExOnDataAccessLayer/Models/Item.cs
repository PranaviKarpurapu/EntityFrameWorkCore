using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExOnDataAccessLayer.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }

    }
}
