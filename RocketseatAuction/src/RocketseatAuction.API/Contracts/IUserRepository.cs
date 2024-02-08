using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IUserRepository
{
    bool ExistUserEmail(string email);
    User GetUserByEmail(string email);
}
