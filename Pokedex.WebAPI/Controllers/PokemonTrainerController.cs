using Microsoft.AspNetCore.Mvc;
using Pokedex.Core.Interfaces;
using Pokedex.Domain.Dto;
using System;

namespace Pokedex.WebAPI.Controllers
{
    [ApiController]
    [Route("/api/pokemontrainer")]
    public class PokemonTrainerController : Controller
    {
        private readonly IPokemonTrainerService _pokemonTrainerService;

        public PokemonTrainerController(IPokemonTrainerService pokemonTrainerService)
        {
            _pokemonTrainerService = pokemonTrainerService ?? throw new ArgumentNullException(nameof(pokemonTrainerService));
        }

        [HttpPost("create")]
        public IActionResult Create(PokemonTrainerDto request)
        {
            try
            {
                var response = _pokemonTrainerService.Add(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                var uuid = Guid.NewGuid();
                Console.WriteLine($" --- Error uuid: {uuid} ---");
                Console.WriteLine($"Error Message {ex.Message}");
                Console.WriteLine($"Error StackTrace {ex.StackTrace}");
                return StatusCode(500, $"Error id: {uuid}");
            }
        }

        [HttpPost("update")]
        public IActionResult Update(PokemonTrainerUpdateDto request)
        {
            try
            {
                var response = _pokemonTrainerService.Update(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                var uuid = Guid.NewGuid();
                Console.WriteLine($" --- Error uuid: {uuid} ---");
                Console.WriteLine($"Error Message {ex.Message}");
                Console.WriteLine($"Error StackTrace {ex.StackTrace}");
                return StatusCode(500, $"Error id: {uuid}");
            }
        }
    }
}
