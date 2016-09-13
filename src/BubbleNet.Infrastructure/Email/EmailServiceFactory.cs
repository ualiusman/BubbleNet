using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Email
{
    public class EmailServiceFactory
    {
        private static IEmailService _emailService;

        public static void InitiliazeEmailService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public static IEmailService GetEmailService()
        {
            return _emailService;
        }
    }
}
