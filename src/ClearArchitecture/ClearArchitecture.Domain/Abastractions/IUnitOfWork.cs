namespace ClearArchitecture.Domain.Abstractions;

public interface IUnitOfWork
{
    //usado para las interfaces
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}