using ClearArchitecture.Domain.Vehiculos;

namespace ClearArchitecture.Infraestructure.Repositories;


internal sealed class VehiculoRepository : Repository<Vehiculo>, IVehiculoRepository
{
    public VehiculoRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
