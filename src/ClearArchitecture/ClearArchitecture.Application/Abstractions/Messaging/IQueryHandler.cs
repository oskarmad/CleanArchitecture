using ClearArchitecture.Domain.Abstractions;
using MediatR;

namespace ClearArchitecture.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse>
: IRequestHandler<TQuery, Result<TResponse>>
where TQuery : IQuery<TResponse>
{

}