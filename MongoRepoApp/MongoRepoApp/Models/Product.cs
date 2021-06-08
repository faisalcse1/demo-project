using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MongoRepoApp.Models
{
    public class Product
    {
        public string Id { get; set; }
        [Display(Name = "Item Name")]
        public  string ItemName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        [Display(Name = "Category")]
        public string CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
