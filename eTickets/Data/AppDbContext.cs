using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        // allows base class DbContext to be initialized with these options when creating an instance of AppDbContext
        // aka inheritance
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //override of method in base class to provide custom behavior specific to AppDbContext class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            // Creating database relationship connection for Actor Movies
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ActorId);

            // calls same method in base class, which allows it to execute its default behavior before any additional custom mods are made in the AppDbContext class
            base.OnModelCreating(modelBuilder);
        }

        //datatable names for each model
        public DbSet <Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }



    }

}
