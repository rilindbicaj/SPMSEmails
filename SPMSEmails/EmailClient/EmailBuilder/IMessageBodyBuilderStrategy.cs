using SPMSEmails.EmailClient.DataObjects;

namespace SPMSEmails.EmailClient.EmailBuilder
{
    public interface IMessageBodyBuilderStrategy
    {
        string BuildMessageBody(EmailData emailData);
    }
}