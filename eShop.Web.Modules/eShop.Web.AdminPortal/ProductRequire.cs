using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Web.AdminPortal
{
    public class ProductRequire
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string Brand { get; set; }      
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string ImageLink { get; set; }
        [Required]
        public string Description { get; set; }
    }
}