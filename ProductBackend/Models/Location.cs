using System.ComponentModel.DataAnnotations;
namespace ProductBackend.Models
{
    public class Location
    {
        [Key]
        public int locationId { get; set; }
        [Required]
        public String street { get; set; }
        [Required]
        public int houseNumber { get; set; }
        [Required]
        public String city { get; set; }
        [Required]
        public String zipCode { get; set; }

        public Location(string street, int houseNumber, string city, string zipCode)
        {
            this.street = street;
            this.houseNumber = houseNumber;
            this.city = city;
            this.zipCode = zipCode;
        }

        public Location(int locationId, string street, int houseNumber, string city, string zipCode)
        {
            this.locationId = locationId;
            this.street = street;
            this.houseNumber = houseNumber;
            this.city = city;
            this.zipCode = zipCode;
        }
    }
}
