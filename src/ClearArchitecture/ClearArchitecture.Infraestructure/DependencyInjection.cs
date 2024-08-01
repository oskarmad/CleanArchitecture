
using ClearArchitecture.Application.Abstractions.Clock;
using ClearArchitecture.Application.Abstractions.Data;
using ClearArchitecture.Application.Abstractions.Email;
using ClearArchitecture.Domain.Abstractions;
using ClearArchitecture.Domain.Alquileres;
using ClearArchitecture.Domain.Users;
using ClearArchitecture.Domain.Vehiculos;
using ClearArchitecture.Infraestructure.Clock;
using ClearArchitecture.Infraestructure.Data;
using ClearArchitecture.Infraestructure.Repositories;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClearArchitecture.Infraestructure;

public static class DependencyInjection
{

    public static IServiceCollection AddInfraestructure(
        this IServiceCollection services,
        IConfiguration configuration
        )
    {

        services.AddTransient<IDateTimeProvider, DateTimeProvider>();
        services.AddTransient<IEmailService, EmailService>();

        var connectionString = configuration.GetConnectionString("Database")
             ?? throw new ArgumentNullException(nameof(configuration));

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
        });

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IVehiculoRepository, VehiculoRepository>();
        services.AddScoped<IAlquilerRepository, AlquilerRepository>();

        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());

        services.AddSingleton<ISqlConnectionFactory>(_ => new SqlConnectionFactory(connectionString));

        SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());
        return services;
    }

}