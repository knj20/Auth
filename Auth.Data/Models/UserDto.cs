using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Data.Models
{
    internal class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public RoleDto Role { get; set; }

    }
}
