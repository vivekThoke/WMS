using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WMS.Domain.Entities;

namespace WMS.Infrastructure.Data
{
    public class WmsDbContext : DbContext
    {
        public WmsDbContext(DbContextOptions<WmsDbContext> options) : base(options) { }

        public DbSet<WorkRequest> WorkRequests => Set<WorkRequest>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WorkRequest>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);
            });

            
        }
    }
}
