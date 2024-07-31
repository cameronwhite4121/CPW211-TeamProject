using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_TeamProject.Models
{
    /// <summary>
    /// This class represents a weapon that a character uses
    /// Ex. Captain America's shield, Batman Batarangs.
    /// </summary>
    public partial class weapon
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ComicBookDebut { get; set; }

        public DateTime DebutDate { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<character> User { get; set; }
    }
}
