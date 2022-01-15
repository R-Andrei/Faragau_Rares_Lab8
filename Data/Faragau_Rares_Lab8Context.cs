using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Faragau_Rares_Lab8.Models;

namespace Faragau_Rares_Lab8.Data
{
    public class Faragau_Rares_Lab8Context : DbContext
    {
        public Faragau_Rares_Lab8Context (DbContextOptions<Faragau_Rares_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Faragau_Rares_Lab8.Models.Book> Book { get; set; }

        public DbSet<Faragau_Rares_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Faragau_Rares_Lab8.Models.Category> Category { get; set; }
    }
}
