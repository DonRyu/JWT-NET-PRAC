using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_NET_PRAC.Models
{
    public class UserDto
    {
        public required string Username { get; set; } = string.Empty;
        public required string Password { get; set; } = string.Empty;
    }
}