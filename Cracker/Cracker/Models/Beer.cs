using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cracker.Models
{
    public class Beer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Името трябва да е по малко от 25 символа")]
        public string Name { get; set; }

        [Required]
        [Range(0, 20000)]
        public double Price { get; set; }

        [Range(0, 12.0)]
        public double Alcohol { get; set; }

        public string ImagePath { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public BeerType BeerType { get; set; }

        public BeerStyle BeerStyle { get; set; }

        [Display(Name = "Производител")]
        public int BeerHouseId { get; set; }

        public virtual BeerHouse Beerhouse { get; set; }
    }
}
