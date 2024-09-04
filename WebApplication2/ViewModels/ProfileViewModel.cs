namespace WebApplication2.ViewModels;
public class ProfileViewModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string PhoneNumber { get; set; }
    public IFormFile ProfilePictureFile { get; set; } // Dosya yüklemek için
    public string ProfilePictureUrl { get; set; } // Profil fotoğrafının URL'si
}
