using System.ComponentModel.DataAnnotations;

namespace nguyenminhtuan_2459.DTOs.Auth;

public class ResendOtpDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Type { get; set; } = "LOGIN"; // LOGIN, REGISTER, RESET_PASSWORD
}
