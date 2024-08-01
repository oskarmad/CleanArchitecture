using ClearArchitecture.Domain.Users;

namespace ClearArchitecture.Infraestructure.Repositories;

internal sealed class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}