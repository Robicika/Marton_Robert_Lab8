using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marton_Robert_Lab8.Models;

namespace Marton_Robert_Lab8.Data
{
    public class Marton_Robert_Lab8Context : DbContext
    {
        public Marton_Robert_Lab8Context (DbContextOptions<Marton_Robert_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Marton_Robert_Lab8.Models.Book> Book { get; set; }

        public DbSet<Marton_Robert_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Marton_Robert_Lab8.Models.Category> Category { get; set; }
    }
}
