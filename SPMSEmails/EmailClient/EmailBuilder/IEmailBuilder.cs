using SPMSEmails.EmailClient.DataObjects;

namespace SPMSEmails.EmailClient.EmailBuilder
{
    
    public interface IEmailBuilder
    {
        
        void SetBuildingStrategy(IMessageBodyBuilderStrategy strategy);
        string BuildBody(EmailData data);
    }
}