using Pokedex.Domain.Entities;
using Pokedex.Domain.Interfaces;
using Pokedex.Infrastracture.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokedex.Infrastracture.Data.Repositories
{
    public class PokemonTrainerRepository : IPokemonTrainerRepository
    {
        private readonly PokedexDbContext _ctx;

        public PokemonTrainerRepository(PokedexDbContext dbContext)
        {
            _ctx = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public PokemonTrainer Add(PokemonTrainer pokemonTrainer)
        {
            _ctx.PokemonTrainer.Add(pokemonTrainer);
            _ctx.SaveChanges();

            return pokemonTrainer;
        }

        public PokemonTrainer Update(PokemonTrainer pokemonTrainer)
        {
            _ctx.PokemonTrainer.Update(pokemonTrainer);
            _ctx.SaveChanges();

            return pokemonTrainer;
        }
    }
}
