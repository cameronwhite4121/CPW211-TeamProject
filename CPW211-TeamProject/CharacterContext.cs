using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_TeamProject
{
    public class CharacterContext : DbContext
    {
        public CharacterContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database connection string
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CharacterIndex;Trusted_Connection=True;");
        }

        /// <summary>
        /// adds character table to database
        /// </summary>
        public DbSet<character> character { get; set; }

        /// <summary>
        /// Adds weapon table to database
        /// </summary>
        public DbSet<weapon> weapon { get; set; }
    }
}
