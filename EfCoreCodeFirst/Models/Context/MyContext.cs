using EfCoreCodeFirst.Models.Configuration;
using EfCoreCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCoreCodeFirst.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options): base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new CatogoryCongiguration());
            modelBuilder.ApplyConfiguration(new OrderCongiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileCongiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
        }


        public DbSet<AppUser> appUsers {  get; set; }
        public DbSet<AppUserProfile> appUserProfiles { get; set; }
        public DbSet<Catagory> catagories { get; set; }
        public DbSet<OrderDetail> orderDetail { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
