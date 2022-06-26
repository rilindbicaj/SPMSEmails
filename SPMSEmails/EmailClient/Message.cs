using Microsoft.AspNetCore.Http;
using MimeKit;
using System.Collections.Generic;
using System.Linq;
using SPMSEmails.EmailClient.DataObjects;
using SPMSEmails.EmailClient.EmailBuilder;

namespace SPMSEmails.EmailClient
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public IFormFileCollection Attachments { get; set; }
        public Message(IEnumerable<string> to, string subject, IFormFileCollection attachments, IMessageBodyBuilderStrategy strategy, EmailData emailData)
        {
            To = new List<MailboxAddress>();

            To.AddRange(to.Select(x => new MailboxAddress(x,x)));
            Subject = subject;
            Content = strategy.BuildMessageBody(this, emailData);
            Attachments = attachments;
        }
    }
}
