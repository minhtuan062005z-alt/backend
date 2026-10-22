using System.ComponentModel.DataAnnotations;

namespace nguyenminhtuan_2459.DTOs.Auth;

public class GoogleAuthDto
{
    [Required]
    public string IdToken { get; set; } = string.Empty;
}
