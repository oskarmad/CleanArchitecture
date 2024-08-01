using ClearArchitecture.Application.Abstractions.Email;
using ClearArchitecture.Domain.Users;

namespace ClearArchitecture.Infraestructure;

internal sealed class EmailService : IEmailService
{
    public Task SendAsync(Email recipient, string subject, string body)
    {
        return Task.CompletedTask;
    }
}