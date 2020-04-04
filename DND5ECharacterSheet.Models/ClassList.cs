using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Models
{
    public class ClassList
    {
        [Key]
        public int ClassId { get; set; }

        [Required]
        [Display(Name = "Class")]
        public string ClassName { get; set; }
    }
}
