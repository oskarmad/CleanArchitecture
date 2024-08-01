using ClearArchitecture.Domain.Alquileres;
using ClearArchitecture.Domain.Vehiculos;
using Microsoft.EntityFrameworkCore;

namespace ClearArchitecture.Infraestructure.Repositories;

internal sealed class AlquilerRepository : Repository<Alquiler>, IAlquilerRepository
{
    private static readonly AlquilerStatus[] ActiveAlquilerStatuses = {
        AlquilerStatus.Reservado,
        AlquilerStatus.Confirmado,
        AlquilerStatus.Completado
    };

    public AlquilerRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> IsOverlappingAsync(
        Vehiculo vehiculo,
        DateRange duracion,
        CancellationToken cancellationToken = default)
    {

        return await DbContext.Set<Alquiler>()
        .AnyAsync(
            alquiler =>
                alquiler.VehiculoId == vehiculo.Id &&
                alquiler.Duracion!.Inicio <= duracion.Fin &&
                alquiler.Duracion.Fin >= duracion.Inicio &&
                ActiveAlquilerStatuses.Contains(alquiler.Status),
                cancellationToken
        );
    }
}