

using System.Data;

namespace ClearArchitecture.Application.Abstractions.Data;

public interface ISqlConnectionFactory
{

    IDbConnection CreateConnection();

}