using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace ProductBackend.Dto
{
    public class SuperMarketProductDto
    {
        public SuperMarketProductDto(int spmktId, int prdtId, string spmName, string prdtName,  decimal price)
        {
            this.spmktId = spmktId;
            this.prdtId = prdtId;
            this.spmName = spmName;
            this.prdtName = prdtName;
            this.price = price;
        }

        public int spmktId { get; }
        public int prdtId { get; }
        public string spmName { get; }
        public string prdtName { get; }
        public decimal price { get; }
    }
}
