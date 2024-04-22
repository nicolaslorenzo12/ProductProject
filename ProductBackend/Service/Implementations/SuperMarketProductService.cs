using ProductBackend.Dto;
using ProductBackend.Models;
using ProductBackend.Repository.Interfaces;
using ProductBackend.Service.Interfaces;

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

        public async Task ChangeThePriceOfAProductInASuperMarket(SuperMarketProductDto superMarketProductDto)
        {
            Product product = await productRepository.GetProductByIdAsync(superMarketProductDto.prdtId);
            SuperMarket superMarket = await superMarketRepository.GetSuperMarketByIdAsync(superMarketProductDto.spmktId);
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
                SuperMarketProduct superMarketProductToChangePrice = await superMarketProductRepository.FindSuperMarketProductByProductAndSuperMarketId(product.Id, superMarket.Id);
                await superMarketProductRepository.UpdatePriceOfAProductInASuperMarketAsync(superMarketProductToChangePrice, newPrice);
            }

        }

        public async Task<IReadOnlyCollection<SuperMarketProduct>> GetSuperMarketProductsOfASuperMarket(int superMarketId)
        {
            return await superMarketProductRepository.ReadSuperMarketProductsOfASuperMarket(superMarketId);
        }
    }
}
