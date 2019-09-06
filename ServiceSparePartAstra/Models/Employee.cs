using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceSparePartAstra.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Marital { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public Sex Sex { get; set; }
        public TaxStatus Tax { get; set; } 
    }

    public enum TaxStatus
    {
        S0,S1,S2,S3,M0,M1,M2,M3
    }
}
