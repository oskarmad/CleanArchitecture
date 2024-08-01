using ClearArchitecture.Application.Abstractions.Messaging;

namespace ClearArchitecture.Application.Alquileres.ReservarAlquiler;

public record ReservarAlquilerCommand(
    Guid VehiculoId,
    Guid UserId,
    DateOnly FechaInicio,
    DateOnly FechaFin

) : ICommand<Guid>;