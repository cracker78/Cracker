using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cracker.Models
{
    public class Winery
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        public Country Country { get; set; }

        public virtual ICollection<Wine> Wines { get; set; }
    }
}
