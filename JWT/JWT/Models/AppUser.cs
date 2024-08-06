using Microsoft.AspNetCore.Identity;

namespace JWT.Models
{
    //Heredamos la clase IdentityUser 
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

    }
}
