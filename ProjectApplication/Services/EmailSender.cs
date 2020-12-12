using System;
using System.Security.Claims;
using System.Text;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;
using Org.BouncyCastle.Crypto.Tls;
using ProjectApplication.Models;
using Task = System.Threading.Tasks.Task;

namespace ProjectApplication.Services
{
   

    public class EmailService
    {
        private IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();
 
            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "www.rogachev.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };
             
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync( _configuration["Email:host"], Int32.Parse(_configuration["Email:port"]), false);
                await client.AuthenticateAsync(_configuration["Email:Login"], _configuration["Email:Password"]);
                await client.SendAsync(emailMessage);
 
                await client.DisconnectAsync(true);
            }
        }
    }
}