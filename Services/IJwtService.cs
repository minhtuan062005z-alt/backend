using System.Security.Claims;
using nguyenminhtuan_2459.Models;

namespace nguyenminhtuan_2459.Services;

public interface IJwtService
{
    string GenerateToken(User user, int? studentId = null, int? teacherId = null);
    ClaimsPrincipal? ValidateToken(string token);
}
