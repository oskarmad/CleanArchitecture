using ClearArchitecture.Application.Abstractions.Messaging;

namespace ClearArchitecture.Application.Vehiculos.SearchVehiculos;

public sealed record SearchVehiculosQuery(
    DateOnly fechaInicio,
    DateOnly fechaFin
) : IQuery<IReadOnlyList<VehiculoResponse>>;
