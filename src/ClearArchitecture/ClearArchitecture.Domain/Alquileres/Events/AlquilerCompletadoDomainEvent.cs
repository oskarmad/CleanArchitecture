using ClearArchitecture.Domain.Abstractions;

namespace ClearArchitecture.Domain.Alquileres.Events;


public sealed record AlquilerCompletadoDomainEvent(Guid AlquilerId) : IDomainEvent;