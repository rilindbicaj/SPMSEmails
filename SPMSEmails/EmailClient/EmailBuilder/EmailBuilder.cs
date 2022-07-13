using System;
using SPMSEmails.EmailClient.DataObjects;

namespace SPMSEmails.EmailClient.EmailBuilder
{
    public class EmailBuilder : IEmailBuilder
    {

        private IMessageBodyBuilderStrategy _strategy;
        
        public void SetBuildingStrategy(IMessageBodyBuilderStrategy strategy)
        {
            _strategy = strategy;
        }

        public string BuildBody(EmailData data)
        {

            if (_strategy == null)
                throw new InvalidOperationException("Body building strategy is not set.");

            return _strategy.BuildMessageBody(data);
        }
    }
}