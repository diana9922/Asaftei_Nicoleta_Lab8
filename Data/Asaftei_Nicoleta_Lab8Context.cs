using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asaftei_Nicoleta_Lab8.Models;

namespace Asaftei_Nicoleta_Lab8.Data
{
    public class Asaftei_Nicoleta_Lab8Context : DbContext
    {
        public Asaftei_Nicoleta_Lab8Context (DbContextOptions<Asaftei_Nicoleta_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Asaftei_Nicoleta_Lab8.Models.Book> Book { get; set; }

        public DbSet<Asaftei_Nicoleta_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
