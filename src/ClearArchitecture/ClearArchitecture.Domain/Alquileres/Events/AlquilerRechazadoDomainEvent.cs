using ClearArchitecture.Domain.Abstractions;

namespace ClearArchitecture.Domain.Alquileres.Events;

public sealed record AlquilerRechazadoDomainEvent(Guid Id) : IDomainEvent;