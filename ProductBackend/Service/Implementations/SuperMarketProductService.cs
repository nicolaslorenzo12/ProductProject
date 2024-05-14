using ProductBackend.Dto;
using ProductBackend.Models;
using ProductBackend.Repository.Interfaces;
using ProductBackend.Service.Interfaces;
using System.Collections.ObjectModel;

namespace ProductBackend.Service.Implementations
{
    public class SuperMarketProductService : ISuperMarketProductService
    {

        public readonly ISuperMarketProductRepository superMarketProductRepository;
        public readonly IProductRepository productRepository;
        public readonly ISuperMarketRepository superMarketRepository;

        public SuperMarketProductService(ISuperMarketProductRepository superMarketProductRepository, IProductRepository productRepository, ISuperMarketRepository superMarketRepository)
        {
            this.superMarketProductRepository = superMarketProductRepository;
            this.productRepository = productRepository;
            this.superMarketRepository = superMarketRepository;
        }

        public async Task ChangeThePriceOfAProductInASuperMarketAsync(SuperMarketProductDto superMarketProductDto)
        {
            Product product = await productRepository.FindProductByIdAsync(superMarketProductDto.prdtId);
            SuperMarket superMarket = await superMarketRepository.FindSuperMarketByIdAsync(superMarketProductDto.spmktId);
            decimal newPrice = superMarketProductDto.price;

            if(product == null)
            {
                throw new ArgumentNullException("This product was not found in the database.");
            }
            else if(superMarket == null)
            {
                throw new ArgumentNullException("This supermarket was not found in the database.");
            }
            else
            {
                SuperMarketProduct superMarketProductToChangePrice = await superMarketProductRepository.FindSuperMarketProductByProductAndSuperMarketIdAsync(product.Id, superMarket.Id);
                await superMarketProductRepository.UpdatePriceOfAProductInASuperMarketAsync(superMarketProductToChangePrice, newPrice);
            }

        }

        public async Task<List<SuperMarketProductDto>> GetSuperMarketProductsOfASuperMarketAsync(int superMarketId)
        {
            List<SuperMarketProduct> supermarketProducts = await superMarketProductRepository.ReadSuperMarketProductsOfASuperMarketAsync(superMarketId);
            List<SuperMarketProductDto> supermarketProductsDto = new List<SuperMarketProductDto>();
            supermarketProducts.ForEach(p => { supermarketProductsDto.Add(new SuperMarketProductDto(p.ProductId, p.SuperMarket.Id, p.SuperMarket.name, p.Product.ProductName ,p.Price)); });
            return supermarketProductsDto;
        }
    }
}
