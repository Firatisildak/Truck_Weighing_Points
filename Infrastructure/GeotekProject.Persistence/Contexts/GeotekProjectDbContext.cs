using GeotekProject.Domain.Entities;
using GeotekProject.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Persistence.Contexts
{
    public class GeotekProjectDbContext:DbContext
    {
        public GeotekProjectDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Kamyon> Kamyons { get; set; }
        public DbSet<Kantar> Kantars { get; set; }
        public DbSet<Bosaltma> Bosaltmas { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                var _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    _ => DateTime.Now,
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
