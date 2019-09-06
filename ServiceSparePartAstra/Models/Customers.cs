using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceSparePartAstra.Models
{
    public class Customers
    {
        [Key]
        public int CustomerID {get;set;}
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerPhoneNumber { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public Sex Sex { get; set; }
    }

    public enum Sex
    {
        Male,Female
    }

}
