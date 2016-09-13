using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Email
{
    public class SMTPService : IEmailService
    {
        public void SendMail(string from, string to, string subject, string body)
        {
            MailMessage message = new MailMessage(from, to);

            message.Subject = subject;
            message.Body = body;
            SmtpClient smtp = new SmtpClient();

            smtp.Send(message);
        }
    }
}
