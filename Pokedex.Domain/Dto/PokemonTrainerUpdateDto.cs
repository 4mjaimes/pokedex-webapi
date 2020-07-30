using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pokedex.Domain.Dto
{
    public class PokemonTrainerUpdateDto
    {
        [Required(ErrorMessage = "Field required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Field required")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field required")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Field required")]
        [RegularExpression(@"^(?!.*?\.\.)([A-Za-z0-9_\-.+])+@([A-Za-z0-9_\-.])+\.([A-Za-z]{2,})$", ErrorMessage = "Email invalid")]
        [MaxLength(30)]
        public string Email { get; set; }
    }
}
