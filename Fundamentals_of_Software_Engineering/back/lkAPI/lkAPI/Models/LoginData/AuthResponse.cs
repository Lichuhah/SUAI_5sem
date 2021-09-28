using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lkAPI.Models.Users
{
    public class AuthResponse
    {
        public int id { get; set; }
        public UserRole role { get; set; }
    }
}
