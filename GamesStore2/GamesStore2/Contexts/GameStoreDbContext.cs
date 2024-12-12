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
           

        }
    }


