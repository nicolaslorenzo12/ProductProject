namespace ProductBackend.Dto
{
    public class LocationDto
    {
        public LocationDto(string street, int number, string city, string zip)
        {
            this.street = street;
            this.number = number;
            this.city = city;
            this.zip = zip;
        }

        public string street { get; }
        public int number{ get;}
        public string city { get;}
        public string zip { get;}
    }
}
