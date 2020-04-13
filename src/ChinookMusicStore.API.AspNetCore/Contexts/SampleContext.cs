using ChinookMusicStore.API.AspNetCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace SupplyChain.API.AspNetCore.Contexts
{
    /// <summary>
    /// Database conetext for suppliers to query and save data to database
    /// </summary>
    public class SampleContext: DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed sample data
            //modelBuilder.Entity<Country>()
            //    .HasData(
            //        new Country() { Id = 1, Name = "Netherlands" },
            //        new Country() { Id = 2, Name = "Portugal" },
            //        new Country() { Id = 3, Name = "Spain" }
            //    );

            //modelBuilder.Entity<Sector>()
            //    .HasData(
            //        new Sector() { Id = 1, Name = "Bananas" },
            //        new Sector() { Id = 2, Name = "Strawberries" }
            //    );

            //modelBuilder.Entity<Role>()
            //    .HasData(
            //        new Role() { Id = 1, Name = "Grower" },
            //        new Role() { Id = 2, Name = "Producer" }
            //    );

            //modelBuilder.Entity<Supplier>()
            //    .HasData(
            //        new Supplier() { Id = 1, Name = "Wonderful Ltd.", GGN = "742873287323945678", CountryId = 1 }
            //    );

            //modelBuilder.Entity<SupplierRole>()
            //    .HasData(
            //        new SupplierRole() { Id = 1, SupplierId = 1, RoleId = 1 },
            //        new SupplierRole() { Id = 2, SupplierId = 1, RoleId = 2 }
            //    );

            //modelBuilder.Entity<SupplierSector>()
            //    .HasData(
            //        new SupplierSector() { Id = 1, SupplierId = 1, SectorId = 2 }
            //    );

            ////modelBuilder.Entity<Supplier>().HasOne(c => c.Country).WithMany(s=>s.Suppliers);
            //modelBuilder.Entity<Country>().HasMany(s => s.Suppliers).WithOne(c => c.Country);
            //modelBuilder.Entity<Supplier>().HasMany(x => x.SupplierRoles).WithOne(y => y.Supplier);
            //modelBuilder.Entity<SupplierRole>().HasOne(x => x.Role).WithMany(y => y.SupplierRoles);
            //modelBuilder.Entity<SupplierSector>().HasOne(x => x.Sector).WithMany(y => y.SupplierSectors);

            modelBuilder.Entity<Genre>().HasKey(x => x.GenreId);
            modelBuilder.Entity<Customer>().HasKey(x => x.CustomerId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
