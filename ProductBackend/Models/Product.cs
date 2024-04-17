using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductBackend.Models
{
    public class Product
    {
        public Product(string productName)
        {
            ProductName = productName;
        }

        public Product(int id, string productName)
        {
            Id = id;
            ProductName = productName;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

    }
}
