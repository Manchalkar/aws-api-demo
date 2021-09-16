using Etools.Entities.EntityModels;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etools.Entities.DbContexts
{
    public class EtoolsDbContext : DbContext
    {
        public EtoolsDbContext()
        {

        }
        public EtoolsDbContext(DbContextOptions<EtoolsDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\LocalDBDemo;Database=eTools;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
        public DbSet<Temp> Temp { get; set; }
    }
}
