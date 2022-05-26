using Microsoft.EntityFrameworkCore;
using TestAPI.Models.Domain;

namespace TestAPI.Data
{
    public class APIDbContext: DbContext 
    {
        public APIDbContext(DbContextOptions<APIDbContext> options): base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }


    }
}
