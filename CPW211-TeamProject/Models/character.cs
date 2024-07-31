using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_TeamProject.Models
{
    /// <summary>
    /// This class represents a character, be it a villain, hero or side character.
    /// </summary>
    public partial class character
    {
        public string Name { get; set; }

        public string Alias { get; set; }

        public string SuperPower { get; set; }

        public virtual ICollection<weapon> Weapon { get; set; }

        public string ComicBookDebut { get; set; }

        public DateTime DebutDate { get; set; }

        public string ImageUrl { get; set; }
    }
}
