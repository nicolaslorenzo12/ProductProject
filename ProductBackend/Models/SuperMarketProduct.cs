using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductBackend.Models
{
    public class SuperMarketProduct
    {
        public SuperMarketProduct(int superMarketId, int productId, decimal price)
        {
            SuperMarketId = superMarketId;
            ProductId = productId;
            Price = price;
        }

        public SuperMarketProduct(SuperMarket superMarket, Product product, decimal price)
        {
            Price = price;
            SuperMarket = superMarket;
            Product = product;
        }

        [Key, Column(Order = 0)]
        [ForeignKey("SuperMarket")]
        public int SuperMarketId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public SuperMarket SuperMarket { get; set; }
        public Product Product { get; set; }
    }
}
