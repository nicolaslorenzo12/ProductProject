using ProductBackend.Models;
namespace ProductBackend.Dto
{
    public class AddSuperMarketDto
    {
        public AddSuperMarketDto(string name, int? locationId)
        {
            Name = name;
            LocationId = locationId;
        }

        public string Name { get;}
        public int? LocationId {  get;}
    }
}
