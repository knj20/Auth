using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Data.Models
{
    internal class RoleDto
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
