using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.Entities;
using Pokedex.Infrastracture.Data.Config;

namespace Pokedex.Infrastracture.Data.Context
{
    public class PokedexDbContext : DbContext
    {
        public PokedexDbContext(DbContextOptions<PokedexDbContext> options) : base(options) { }

        public DbSet<PokemonTrainer> PokemonTrainer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PokemonTrainerConfiguration());
        }
    }
}
