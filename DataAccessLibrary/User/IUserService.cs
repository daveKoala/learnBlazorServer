using System.Collections.Generic;

namespace DataAccessLibrary.User
{
    public interface IUserService
    {
        IEnumerable<User> Get();
    }
}