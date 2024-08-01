using ClearArchitecture.Domain.Abstractions;
using MediatR;

namespace ClearArchitecture.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{

}