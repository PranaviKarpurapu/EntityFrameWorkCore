using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLayer.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string Eid { get; set; }

        [Required]
        [StringLength(30)]
        public string Ename { get; set; }
        

        [Column(TypeName ="Date")]    //To take type as Date
        public DateTime? JoinDate { get; set; }


        [StringLength(20)]
        public string Designation { get; set; }
        public decimal? Salary { get; set; }
        public int ProjectID { get; set; }


        //Navigation Property
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

    }
}
