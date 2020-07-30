using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokedex.Domain.Entities;


namespace Pokedex.Infrastracture.Data.Config
{
    public class PokemonTrainerConfiguration : IEntityTypeConfiguration<PokemonTrainer>
    {
        public void Configure(EntityTypeBuilder<PokemonTrainer> builder)
        {
            builder.HasKey(pt => pt.Id);

            builder.Property(pt => pt.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(pt => pt.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(pt => pt.Email)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
