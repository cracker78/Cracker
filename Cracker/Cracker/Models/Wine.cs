using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cracker.Models
{
    public class Wine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Името трябва да е по малко от 25 символа")]
        public string Name { get; set; }

        [Required]
        [Range(0,20000)]
        public double Price { get; set; }

        [Range(1900, 2019)]
        public int YearBottling { get; set; }

        [Range(8.5, 20.0)]
        public double Alcohol { get; set; }

        public string ImagePath { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public WineType WineType { get; set; }

        [Display(Name="Винарна")]
        public int WineryId { get; set; }

        public virtual Winery Winery { get; set; }
    }
}
