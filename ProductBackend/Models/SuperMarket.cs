﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ProductBackend.Models
{
    public class SuperMarket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [AllowNull]
        public int LocationId { get; set; }

        [ForeignKey("LocationId")]
        [AllowNull]
        public Location Location { get; set; }

        public SuperMarket(string name)
        {
            this.name = name;
        }

        public SuperMarket(string name, Location location)
        {
            this.name = name;
            Location = location;
            LocationId = location.locationId;
        }

        public SuperMarket(int id, string name)
        {
            Id = id;
            this.name = name;
        }

        public SuperMarket(int id, string name, Location location)
        {
            Id = id;
            this.name = name;
            Location = location;
            LocationId = location.locationId;
        }

        public void AddLocation(Location location)
        {
            this.Location = location;
            this.LocationId = location.locationId;
        }
    }
}
