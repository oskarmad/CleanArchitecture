using ClearArchitecture.Domain.Abstractions;
using ClearArchitecture.Domain.Users.Events;

namespace ClearArchitecture.Domain.Users;

public sealed class User : Entity
{
    private User() { }
    private User(
        Guid id,
        Nombre nombre,
        Apellido apellido,
        Email email
        ) : base(id)
    {
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
    }

    public Nombre? Nombre { get; private set; }
    public Apellido? Apellido { get; private set; }
    public Email? Email { get; private set; }

    public static User Create(
        Nombre nombre,
        Apellido apellido,
        Email email
    )
    {
        var user = new User(Guid.NewGuid(), nombre, apellido, email);
        //publica un evento / publisher
        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));
        return user;
    }

}