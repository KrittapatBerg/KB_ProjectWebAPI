using KB_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace KB_WebAPI.databaseContext
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions options) : base(options) { }

        #region Table mapping
        public virtual DbSet<csAttraction> Attractions { get; set; }
        public virtual DbSet<csUser> Users { get; set; }
        public virtual DbSet<csAddress> Addresses { get; set; }
        public virtual DbSet<csReview> Reviews { get; set; }
        public virtual DbSet<csRating> Ratings { get; set; }
        #endregion

        #region Model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<csAddress>()
                .HasKey(a => a.AddressId);

            modelBuilder.Entity<csAttraction>()
                .HasKey(a => a.AttractionId);

            modelBuilder.Entity<csAttraction>()
                .HasOne(a => a.Address)
                .WithOne(a => a.Attraction)
                .HasForeignKey<csAddress>(a => a.AttractionId)
                .IsRequired(false);      //use this if the relation is optional


            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
