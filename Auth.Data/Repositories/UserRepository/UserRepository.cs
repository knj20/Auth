using Auth.Data.Extentions;
using Auth.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Auth.Data.Repositories.UserRepository
{
    internal class UserRepository : IUserRepository
    {
        private List<UserDto> users = new List<UserDto>
        {
            new UserDto{
                Id = Guid.NewGuid(),
                Name = "knj20",
                Password = "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=",
                Email = "exemple@gmail.com",
                Role = new RoleDto
                {
                    Id = Guid.NewGuid(),
                    Name = "SuperUser",
                    Code = 10000
                }
            }
        };
        public UserDto GetUserByUserNameAndPassword(string userName,string password)
        {
            var user = users.SingleOrDefault(u => u.Name.Equals(userName) && u.Password.Equals(password.Sha256()));
            return user;
        }
    }
}
