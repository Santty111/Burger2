using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Burger2.Models;

namespace Burger2.Data
{
    public class Burger2Context : DbContext
    {
        public Burger2Context (DbContextOptions<Burger2Context> options)
            : base(options)
        {
        }

        public DbSet<Burger2.Models.Burger> Burger { get; set; } = default!;
    }
}
