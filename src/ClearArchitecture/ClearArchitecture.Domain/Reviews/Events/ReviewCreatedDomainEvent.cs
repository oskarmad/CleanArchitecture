using ClearArchitecture.Domain.Abstractions;

namespace ClearArchitecture.Domain.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid AlquilerId) : IDomainEvent;