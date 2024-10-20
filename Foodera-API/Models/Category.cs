using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodera_API.Models
{
    public class Category
    {
        public Category() { 
            this.product = new List<Product>();
        }
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; } = "None";
        public string Description { get; set; }
        [ForeignKey("order")]
        public int orderId { get; set; }
        public Order order { get; set; }
        public List<Product> product { get; set; }
    }
}
