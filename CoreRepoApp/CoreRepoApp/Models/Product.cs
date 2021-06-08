using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRepoApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter item name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter price")]
        public decimal Price { get; set; }
    }
}
