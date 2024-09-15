using GeotekProject.Domain.Entities;
using GeotekProject.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GeotekProject.Persistence.Context
{
    public class GeotekProjectDbContext : DbContext
    {
        public GeotekProjectDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Kamyon> Kamyons { get; set; }
        public DbSet<Kantar> Kantars { get; set; }
        public DbSet<Bosaltma> Bosaltmas { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.UtcNow;
                    entry.Entity.Id = Guid.NewGuid();
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Property(e => e.CreatedDate).IsModified = false;
                    entry.Property(e => e.Id).IsModified = false;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
