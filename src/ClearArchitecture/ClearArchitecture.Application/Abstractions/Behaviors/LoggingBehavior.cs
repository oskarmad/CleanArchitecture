using ClearArchitecture.Application.Abstractions.Messaging;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ClearArchitecture.Application.Abstractions.Behaviors;

public class LoggingBehavior<TRequest, TResponse>
: IPipelineBehavior<TRequest, TResponse>
where TRequest : IBaseCommand
{
    private readonly ILogger<TRequest> _logger;

    public LoggingBehavior(ILogger<TRequest> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken
        )
    {
        var name = request.GetType().Name;

        try
        {
            _logger.LogInformation($"Ejecutando el command request: {name}");
            var result = await next();
            _logger.LogInformation($"El comando {name} se ejecuto exitosamente");

            return result;
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, $"El comando {name} tuvo errores");
            throw;
        }

    }
}
