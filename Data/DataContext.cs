using Microsoft.EntityFrameworkCore;
using SuperHeroesBackend.Models;

namespace SuperHeroesBackend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
