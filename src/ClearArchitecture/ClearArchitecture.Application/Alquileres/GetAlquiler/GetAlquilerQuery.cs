using ClearArchitecture.Application.Abstractions.Messaging;

namespace ClearArchitecture.Application.Alquileres.GetAlquiler;


public sealed record GetAlquilerQuery(Guid AlquilerId) : IQuery<AlquilerResponse>;
