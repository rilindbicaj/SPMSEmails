using System.Collections.Generic;

namespace SPMSEmails.EmailClient.DataObjects
{
    public class EmailData
    {
       public List<string> To { get; set; }
       public string EventType { get; set; }
    }
}