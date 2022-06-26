using System.Threading.Tasks;
using SPMSEmails.DTOs;
using SPMSEmails.EmailClient.DataObjects;

namespace SPMSEmails.Services
{
    public interface IEmailService
    {
        Task SendTestEmail(TestEmailDataDTO testEmailDataDto);
        Task SendStudentGradedNotificationEmail(StudentGradedEmailData studentGradedEmailData);
        
    }
}