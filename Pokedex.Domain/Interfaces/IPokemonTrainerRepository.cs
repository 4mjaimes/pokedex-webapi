using Pokedex.Domain.Entities;


namespace Pokedex.Domain.Interfaces
{
    public interface IPokemonTrainerRepository
    {
        PokemonTrainer Add(PokemonTrainer pokemonTrainer);
        PokemonTrainer Update(PokemonTrainer pokemonTrainer);
    }
}
