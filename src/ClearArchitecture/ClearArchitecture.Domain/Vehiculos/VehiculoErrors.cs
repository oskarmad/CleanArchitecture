using ClearArchitecture.Domain.Abstractions;

namespace ClearArchitecture.Domain.Vehiculos;


public static class VehiculoErrors
{
    public static Error NotFound = new(
        "Vehiculo.Found",
        "No existe un vehiculo con este id"
    );
}