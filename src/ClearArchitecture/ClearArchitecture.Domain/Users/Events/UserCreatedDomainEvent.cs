using ClearArchitecture.Domain.Abstractions;

namespace ClearArchitecture.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;