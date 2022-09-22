using Auth.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Data.Repositories.UserRepository
{
    public interface IUserRepository
    {
        public UserDto GetUserByUserNameAndPassword(string userName, string password);
    }
}
