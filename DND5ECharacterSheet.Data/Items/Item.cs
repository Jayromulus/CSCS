using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5ECharacterSheet.Data.Items
{
    public enum Currency { Copper, Silver, Electrum, Gold, Platinum }

    public abstract class Item
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int CurrencyRequired { get; set; }
        [Required]
        public Currency CurrencyType { get; set; }
    }
}
