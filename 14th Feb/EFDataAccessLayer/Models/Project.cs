using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLayer.Models
{
    [Table("Project")]
    public class Project
    {
        [Key]   //Set Primary Key
        public int ProjectID { get; set; }


        [Required]  //Set Not Null
        [StringLength(30)]
        public string ProjectName { get; set; }


        //Set one to many relation with Employee

        [Column(TypeName = "Date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? EndDate { get; set; }
        public IEnumerable<Employee> Employees { get; set; }


    }
}
