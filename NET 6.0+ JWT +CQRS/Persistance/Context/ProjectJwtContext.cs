using Microsoft.EntityFrameworkCore;
using NET_6._0__JWT__CQRS.Core.Domain;
using NET_6._0__JWT__CQRS.Persistance.Configurations;

namespace NET_6._0__JWT__CQRS.Persistance.Context
{
    public class ProjectJwtContext:DbContext
    {

        public ProjectJwtContext(DbContextOptions<ProjectJwtContext>options) :base(options)
        {


        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
