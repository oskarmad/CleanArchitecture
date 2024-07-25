using ClearArchitecture.Domain.Vehiculos;

namespace ClearArchitecture.Domain.Alquileres;

public interface IAlquilerRepository
{

    Task<Alquiler?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<bool> IsOverlappingAsync(
        Vehiculo vehiculo,
        DateRange duracion,
        CancellationToken cancellationToken = default
    );

    void Add(Alquiler alquiler);

}