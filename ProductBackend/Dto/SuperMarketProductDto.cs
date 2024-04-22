using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace ProductBackend.Dto
{
    public class SuperMarketProductDto
    {
        public SuperMarketProductDto(int spmktId, int prdtId, decimal price)
        {
            this.spmktId = spmktId;
            this.prdtId = prdtId;
            this.price = price;
        }

        public int spmktId { get; }
        public int prdtId { get; }
        public decimal price { get; }
    }
}
