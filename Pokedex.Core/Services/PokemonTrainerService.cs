using Pokedex.Core.Interfaces;
using Pokedex.Domain.Dto;
using Pokedex.Domain.Entities;
using Pokedex.Domain.Interfaces;
using System;


namespace Pokedex.Core.Services
{
    public class PokemonTrainerService : IPokemonTrainerService
    {
        private readonly IPokemonTrainerRepository _pokemonTrainerRepository;

        public PokemonTrainerService(IPokemonTrainerRepository pokemonTrainerRepository)
        {
            _pokemonTrainerRepository = pokemonTrainerRepository ?? throw new ArgumentNullException(nameof(pokemonTrainerRepository));
        }
        public PokemonTrainerDto Add(PokemonTrainerDto request)
        {
            var pokemonTrainer = new PokemonTrainer
            {
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email
            };
            var response = _pokemonTrainerRepository.Add(pokemonTrainer);

            var responseDto = new PokemonTrainerDto
            {
                Id = response.Id,
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email
            };

            return responseDto;
        }

        public PokemonTrainerUpdateDto Update(PokemonTrainerUpdateDto request)
        {
            var pokemonTrainer = new PokemonTrainer
            {
                Id = request.Id,
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email
            };

            var response = _pokemonTrainerRepository.Update(pokemonTrainer);

            var responseDto = new PokemonTrainerUpdateDto
            {
                Id = response.Id,
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email
            };

            return responseDto;
        }
    }
}
