using SPMSEmails.EmailClient.DataObjects;

namespace SPMSEmails.EmailClient.EmailBuilder
{
    public interface IMessageBodyBuilderStrategy
    {
        string BuildMessageBody(Message message, EmailData emailData);
    }
}