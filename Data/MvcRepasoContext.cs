using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class MvcRepasoContext : DbContext
    {
        public MvcRepasoContext (DbContextOptions<MvcRepasoContext> options)
            : base(options)
        {
        }

        public DbSet<Mascota> Mascota { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
    }
