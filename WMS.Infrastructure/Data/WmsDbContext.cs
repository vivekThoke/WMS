using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WMS.Domain.Entities;
using WMS.Infrastructure.Identity;


namespace WMS.Infrastructure.Data
{
    public class WmsDbContext : IdentityDbContext<ApplicationUser>
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

                entity.Property(x => x.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(x => x.Status)
                    .IsRequired();
            });

            
        }
    }
}
