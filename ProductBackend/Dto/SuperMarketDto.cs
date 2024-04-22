using ProductBackend.Models;
namespace ProductBackend.Dto
{
    public class SuperMarketDto
    {
        public SuperMarketDto(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string name { get;}
        public int id { get;}
    }
}
