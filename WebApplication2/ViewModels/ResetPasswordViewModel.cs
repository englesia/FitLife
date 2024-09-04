using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ViewModels;
public class ResetPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Code { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}
