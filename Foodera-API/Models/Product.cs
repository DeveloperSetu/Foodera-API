using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodera_API.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        public decimal Quentity { get; set; } = 1;
        public decimal Price { get; set; } = 00;
        [ValidateNever]
        public string Picpath { get; set; }
        [NotMapped]
        public IFormFile ProductPicture { get; set; }
        public bool IsAvailable { get; set; } = true;

        [ForeignKey("category")]
        public int categoryID {  get; set; }
        public Category category { get; set; }

        [ForeignKey("order")]
        public int ordertID {  get; set; }
        public Order order {  get; set; }
    }
}
