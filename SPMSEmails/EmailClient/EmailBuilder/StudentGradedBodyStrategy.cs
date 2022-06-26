using System;
using System.Globalization;
using System.IO;
using SPMSEmails.EmailClient.DataObjects;

namespace SPMSEmails.EmailClient.EmailBuilder
{
    public class StudentGradedBodyStrategy : IMessageBodyBuilderStrategy
    {
        public string BuildMessageBody(Message message, EmailData emailData)
        {
            var data = (StudentGradedEmailData)emailData;
            
            string dueDate = DateTime.Parse(data.DateGraded)
                .AddDays(2).Date.ToShortDateString();
            
            string time = DateTime.Parse(data.DateGraded).TimeOfDay.ToString(); 
            
            string body = File.ReadAllText(Environment.CurrentDirectory + "/Templates/student-graded.html");
            body = body.Replace("{{name}}", data.StudentName)
                .Replace("{{grade}}", data.Grade.ToString())
                .Replace("{{staff}}", data.ProfessorName)
                .Replace("{{time}}", time)
                .Replace("{{dueDate}}", dueDate)
                .Replace("{{course}}", data.Course);
            return body;
        }
    }
}