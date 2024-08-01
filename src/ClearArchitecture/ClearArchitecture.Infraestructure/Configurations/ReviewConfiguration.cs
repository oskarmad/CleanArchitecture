using ClearArchitecture.Domain.Alquileres;
using ClearArchitecture.Domain.Reviews;
using ClearArchitecture.Domain.Users;
using ClearArchitecture.Domain.Vehiculos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClearArchitecture.Infraestructure.Configurations;

internal sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("reviews");

        builder.HasKey(review => review.Id);

        builder.Property(review => review.Rating)
        .HasConversion(rating => rating.Value, value => Rating.Create(value).Value);

        builder.Property(review => review.Comentario)
        .HasMaxLength(200)
        .HasConversion(comentario => comentario.Value, value => new Comentario(value));

        builder.HasOne<Vehiculo>()
        .WithMany()
        .HasForeignKey(review => review.VehiculoId);

        builder.HasOne<Alquiler>()
        .WithMany()
        .HasForeignKey(review => review.AlquilerId);

        builder.HasOne<User>()
        .WithMany()
        .HasForeignKey(review => review.UserId);




    }
}