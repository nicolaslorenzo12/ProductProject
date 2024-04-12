using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductBackend.Models
{
    public class Product
    {
        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public Product(int id, string productName, decimal price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")] // Adjust precision and scale as needed
        public decimal Price { get; set; }
    }
}
