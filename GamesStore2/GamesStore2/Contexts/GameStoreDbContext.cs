using GamesStore2.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesStore2.Contexts
{
    public class GameStoreDbContext:DbContext
    {
        
       
            public GameStoreDbContext(DbContextOptions options) : base(options)
            {

            }
            public DbSet<Games> games { get; set; }
            public DbSet<Reviews> reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reviews>()
                 .HasOne(g => g.games)
                .WithMany(r => r.Reviews)
                .HasForeignKey(g =>g.GameId )
                 .OnDelete(DeleteBehavior.Restrict);

        }


    }
    }


