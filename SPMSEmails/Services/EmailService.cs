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
        private IEmailBuilder _builder;

        public EmailService(IEmailSender sender, IEmailBuilder builder)
        {
            _sender = sender;
            _builder = builder;
        }

        public async Task SendStudentGradedNotificationEmail(StudentGradedEmailData studentGradedEmailData)
        {
            _builder.SetBuildingStrategy(new StudentGradedBodyStrategy());
            string body = _builder.BuildBody(studentGradedEmailData);
            var message = new Message(studentGradedEmailData.To, "Njoftim për notim", body, null);
            await _sender.SendEmailAsync(message);
        }

        public Task SendPostNotificationEmail(PostNotificationEmailData postNotificationEmailData)
        {
            throw new System.NotImplementedException();
        }
    }
}