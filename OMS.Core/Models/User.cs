using Microsoft.AspNetCore.Identity;

namespace OMS.Core.Models
{
    public class User : IdentityUser
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Consider using an enum for roles
                                         // Other properties or methods related to users
    }
}
