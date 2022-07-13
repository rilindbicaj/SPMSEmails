using System.Threading.Tasks;
using SPMSEmails.DTOs;
using SPMSEmails.EmailClient.DataObjects;

namespace SPMSEmails.Services
{
    public interface IEmailService
    {
        Task SendStudentGradedNotificationEmail(StudentGradedEmailData studentGradedEmailData);
        Task SendPostNotificationEmail(PostNotificationEmailData postNotificationEmailData);

    }
}