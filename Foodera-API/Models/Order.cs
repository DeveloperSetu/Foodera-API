using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodera_API.Models
{
    public class Order
    {
        public Order()
        {
            this.category = new List<Category>();
            this.product = new List<Product>();
        }

        [Key]
        [Required]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; } = 0;
        public decimal TotalQuentity { get; set; } = 0;
        public string ProductPicture { get; set; }  
        public List<Category> category { get; set; }
        public List<Product> product { get; set; }
    }
}
