using KB_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace KB_WebAPI
{
    public class sqlContext : DbContext
    {
        public sqlContext(DbContextOptions options): base(options) {  }

        public virtual DbSet<csAttraction> Attractions { get; set; }
        public virtual DbSet<csUser> Users { get; set; }
        public virtual DbSet<csAddress> Address { get; set; }
        public virtual DbSet<csReview> Reviews { get; set; }
        public virtual DbSet<csRating> Rating { get; set; }
    }
}
