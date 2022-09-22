using Auth.Data.Extentions;
using Auth.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Auth.Data.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private List<UserDto> users = new List<UserDto>
        {
            new UserDto{
                Id = Guid.NewGuid(),
                Name = "knj20",
                Password = "123456",
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
            var user = users.SingleOrDefault(u => u.Name.Equals(userName) && u.Password.Equals(password));
            return user;
        }
    }
}
