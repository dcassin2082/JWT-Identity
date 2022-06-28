using Microsoft.AspNetCore.Identity;

namespace WebApplication52.IdentityModels
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
