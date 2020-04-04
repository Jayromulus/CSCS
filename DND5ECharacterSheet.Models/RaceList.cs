using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Models
{
    public class RaceList
    {
        [Key]
        public int RaceId { get; set; }

        [Required]
        [Display(Name = "Race")]
        public string RaceName { get; set; }
    }
}
