using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ViewModels;
public class RegisterViewModel
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

    public string PhoneNumber { get; set; }
    public IFormFile ProfilePicture { get; set; }
}
