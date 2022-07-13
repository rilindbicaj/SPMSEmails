namespace SPMSEmails.EmailClient.DataObjects
{
    public class PostNotificationEmailData : EmailData
    {
        
        public string Title { get; set; }
        public string Contents { get; set; }
        public string DatePosted { get; set; }
        public string Audience { get; set; }
        
    }
}