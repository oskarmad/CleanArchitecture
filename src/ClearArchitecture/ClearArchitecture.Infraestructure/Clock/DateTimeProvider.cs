using ClearArchitecture.Application.Abstractions.Clock;

namespace ClearArchitecture.Infraestructure.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime currentTime => DateTime.UtcNow;
}