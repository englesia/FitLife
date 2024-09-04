using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string ProfilePicture { get; set; } // Profil fotoğrafı yolu
}
