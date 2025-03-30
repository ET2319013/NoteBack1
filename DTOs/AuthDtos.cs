using System.ComponentModel.DataAnnotations;

namespace NotesManager.DTOs
{
    public class RegisterDto
    {    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    }

    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
