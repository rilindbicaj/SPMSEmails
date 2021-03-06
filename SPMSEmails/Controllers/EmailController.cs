using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPMSEmails.DTOs;
using SPMSEmails.EmailClient.DataObjects;
using SPMSEmails.Services;

namespace SPMSEmails.Controllers
{
    
    [ApiController]
    [Route("api/emails")]
    
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("StudentGraded")]

        public async Task<ActionResult> NotifyStudentGraded(StudentGradedEmailData studentGradedEmailData)
        {
            await _emailService.SendStudentGradedNotificationEmail(studentGradedEmailData);
            return Ok("Notified!");
        }

    }
}