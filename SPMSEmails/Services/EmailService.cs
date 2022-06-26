using System.Collections.Generic;
using System.Threading.Tasks;
using SPMSEmails.DTOs;
using SPMSEmails.EmailClient;
using SPMSEmails.EmailClient.DataObjects;
using SPMSEmails.EmailClient.EmailBuilder;

namespace SPMSEmails.Services
{
    public class EmailService : IEmailService
    {
        private readonly IEmailSender _sender;

        public EmailService(IEmailSender sender)
        {
            _sender = sender;
        }
        public async Task SendTestEmail(TestEmailDataDTO testEmailDataDto)
        {
            var to = new List<string> { testEmailDataDto.To };
            var message = new Message(to, testEmailDataDto.Subject, null, null, null);
            await _sender.SendEmailAsync(message);
        }

        public async Task SendStudentGradedNotificationEmail(StudentGradedEmailData studentGradedEmailData)
        {
            var to = studentGradedEmailData.To;
            var message = new Message(to, "Njoftim për notim", null, new StudentGradedBodyStrategy(),
                studentGradedEmailData);
            await _sender.SendEmailAsync(message);
        }
        
    }
}