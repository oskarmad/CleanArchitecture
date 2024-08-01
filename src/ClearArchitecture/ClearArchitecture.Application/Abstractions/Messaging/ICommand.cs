using ClearArchitecture.Domain.Abstractions;
using MediatR;

namespace ClearArchitecture.Application.Abstractions.Messaging;

public interface ICommand : IRequest<Result>, IBaseCommand
{

}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
{

}

public interface IBaseCommand
{ }