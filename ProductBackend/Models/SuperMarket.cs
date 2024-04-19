using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductBackend.Models
{
    public class SuperMarket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        public int LocationId { get; set; }

        [Required]
        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        public SuperMarket(string name)
        {
            this.name = name;
        }

        public SuperMarket(int id, string name)
        {
            Id = id;
            this.name = name;
        }

        public void AddLocation(Location location)
        {
            this.Location = location;
        }
    }
}
