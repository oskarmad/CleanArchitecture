using ClearArchitecture.Domain.Abstractions;

namespace ClearArchitecture.Domain.Alquileres.Events;

public sealed record AlquilerCanceladoDomainEvent(Guid AlquilerId) : IDomainEvent;