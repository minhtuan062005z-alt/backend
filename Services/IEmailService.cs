namespace nguyenminhtuan_2459.Services;

public interface IEmailService
{
    Task SendOtpEmailAsync(string toEmail, string otpCode, string purpose);
    Task SendEmailAsync(string toEmail, string subject, string bodyHtml);
}
