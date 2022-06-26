namespace SPMSEmails.EmailClient.DataObjects
{
    public class StudentGradedEmailData : EmailData
    {
        public string StudentName { get; set; }
        public int Grade { get; set; }
        public string ProfessorName { get; set; }
        public string DateGraded { get; set; }
        public string Course { get; set; }
        
    }
}