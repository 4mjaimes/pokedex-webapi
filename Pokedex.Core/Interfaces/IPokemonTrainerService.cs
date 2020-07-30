using Pokedex.Domain.Dto;

namespace Pokedex.Core.Interfaces
{
    public interface IPokemonTrainerService
    {
        PokemonTrainerDto Add(PokemonTrainerDto request);
        PokemonTrainerUpdateDto Update(PokemonTrainerUpdateDto request);
    }
}
