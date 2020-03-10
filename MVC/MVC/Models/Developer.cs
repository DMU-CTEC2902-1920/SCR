using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public string Platform { get; set; }
        [Range(typeof(decimal), "1", "10")]
        public decimal Rating{ get; set; }
    }
}