namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;

public class RegisterRequest
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Dob { get; set; }

    [Required]
    public string Age { get; set; }

    [Required]
    public string Salary { get; set; }

    [Required]
    public string Department { get; set; }
}