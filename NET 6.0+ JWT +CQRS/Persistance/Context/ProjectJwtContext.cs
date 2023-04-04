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
        public DbSet<Product> Product =>this.Set<Product>();
        public DbSet<Category> Categories => this.Set<Category>();
        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
        public DbSet<AppRole> AppRoles => this.Set<AppRole>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
