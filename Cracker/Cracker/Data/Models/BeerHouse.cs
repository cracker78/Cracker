﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cracker.Data.Models
{
    public class BeerHouse
    {
        public BeerHouse()
        {
            this.Beers = new HashSet<Beer>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        public Country Country { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
