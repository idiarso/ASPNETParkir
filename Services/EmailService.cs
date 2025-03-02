using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace ParkingManagementSystem.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);
        Task SendVerificationEmailAsync(string to, string verificationToken);
        Task SendPasswordResetEmailAsync(string to, string resetToken);
    }

    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;
        private readonly string _fromEmail;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
            _smtpServer = _configuration["Email:SmtpServer"];
            _smtpPort = int.Parse(_configuration["Email:SmtpPort"]);
            _smtpUsername = _configuration["Email:Username"];
            _smtpPassword = _configuration["Email:Password"];
            _fromEmail = _configuration["Email:FromEmail"];
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var message = new MailMessage
            {
                From = new MailAddress(_fromEmail),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
            message.To.Add(new MailAddress(to));

            using var client = new SmtpClient(_smtpServer, _smtpPort)
            {
                Credentials = new NetworkCredential(_smtpUsername, _smtpPassword),
                EnableSsl = true
            };

            await client.SendMailAsync(message);
        }

        public async Task SendVerificationEmailAsync(string to, string verificationToken)
        {
            var verificationLink = $"https://localhost:5205/Account/VerifyEmail?token={verificationToken}&email={WebUtility.UrlEncode(to)}";
            var subject = "Verify Your Email Address";
            var body = $@"<h2>Welcome to Parking Management System!</h2>
                         <p>Please click the link below to verify your email address:</p>
                         <p><a href='{verificationLink}'>Verify Email</a></p>
                         <p>If you didn't create an account, you can ignore this email.</p>";

            await SendEmailAsync(to, subject, body);
        }

        public async Task SendPasswordResetEmailAsync(string to, string resetToken)
        {
            var resetLink = $"https://localhost:5205/Account/ResetPassword?token={resetToken}&email={WebUtility.UrlEncode(to)}";
            var subject = "Reset Your Password";
            var body = $@"<h2>Password Reset Request</h2>
                         <p>Please click the link below to reset your password:</p>
                         <p><a href='{resetLink}'>Reset Password</a></p>
                         <p>If you didn't request a password reset, you can ignore this email.</p>";

            await SendEmailAsync(to, subject, body);
        }
    }
}