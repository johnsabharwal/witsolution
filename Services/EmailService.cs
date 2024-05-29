using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmailService : IEmailService
    {

        private readonly SendGridSettings _config;

        public EmailService(IOptions<SendGridSettings> options)
        {

            _config = options.Value;
        }


        public async Task SendEmailAsync(string email, string subject, string message, string clientName, bool isSendEmailToAdmin)
        {

            try
            {
                var apikey = _config.ApiKey;
                var client = new SendGridClient(apikey);
                var from = new EmailAddress(_config.EmailAddress, _config.EmailName);

                var to = new EmailAddress(isSendEmailToAdmin ? _config.adminEmail : email, isSendEmailToAdmin ? "john" : clientName);
                var plainTextContent = $"<p style=font-size:20px>Hello {clientName} we have recieved your query our sport team will contact you soon </p>";
                if (isSendEmailToAdmin)
                {
                    plainTextContent = $"<p style=font-size:20px;font-family: Georgia, serif;>Hello Admin, Congratulations! We received new query today. Please check details below.</p> <br> Name: {clientName} </p> <br> Email: {email} <br> Subject: {subject} <br> Message: {message}";
                }


                var msg = MailHelper.CreateSingleEmail(from, to, subject, null, plainTextContent);

                var response = await client.SendEmailAsync(msg);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Send grid throw an error {response.Body.ReadAsStringAsync().Result}");
                }
                try
                {
                    response.Headers.GetValues("X-Message-Id").FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Failed while reading header {response.Body.ReadAsStringAsync().Result} {response.Body.Headers} {ex}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SendGridEmailApiAsync function Exception : {ex}.");
            }


        }

    }
}
