using System.Threading.Tasks;

namespace SPMSEmails.EmailClient
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
