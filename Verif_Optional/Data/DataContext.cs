using Microsoft.EntityFrameworkCore;
using Verif_Optional.Models;
using Verif_Optional.Models.Many_to_Many;
using Verif_Optional.Models.One_to_Many;

namespace Verif_Optional.Data
{
    public class DataContext : DbContext
    {
        public DbSet <Autori> Autori { get; set; }

        public DbSet<Model3> Models3 { get; set; }
        public DbSet<Model4> Models4 { get; set; }

        public DbSet<Model1> Models1 { get; set; }
        public DbSet<Model2> Models2 { get; set; }

        public DbSet<AutoriCarti> AutoriCarti { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model3>()
                        .HasMany(m3 => m3.Model4)
                        .WithOne(m4 => m4.Model3);

            modelBuilder.Entity<AutoriCarti>().HasKey(mr => new { mr.Model1Id, mr.Model2Id });
            base.OnModelCreating(modelBuilder);
        }
    }   
}
