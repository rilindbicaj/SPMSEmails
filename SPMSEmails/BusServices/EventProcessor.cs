using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SPMSEmails.EmailClient.DataObjects;
using SPMSEmails.Services;

namespace SPMSEmails.BusServices
{
    public class EventProcessor : IEventProcessor
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public EventProcessor(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        public async Task ProcessEvent(string message)
        {
            var eventType = DetermineEvent(message);

            switch (eventType)
            {
                case EventTypes.StudentGraded:
                    await ProcessStudentGradedEvent(message);
                    break;
            }
        }
        private EventTypes DetermineEvent(string notificationMessage)
        {
            Console.WriteLine("---> determining event");

            var eventType = JsonSerializer.Deserialize<EmailData>(notificationMessage);

            switch (eventType.EventType)
            {
                case "StudentGraded":
                    Console.WriteLine("---> AcademicStaff Published Event Detected");
                    return EventTypes.StudentGraded;
                default:
                    Console.WriteLine("---> Could not determine the event type");
                    return EventTypes.Undetermined;
            }
        }

        private async Task ProcessStudentGradedEvent(string jsonObject)
        {
            var emailData = JsonSerializer.Deserialize<StudentGradedEmailData>(jsonObject);
            await GetEmailService().SendStudentGradedNotificationEmail(emailData);
        }

        private IEmailService GetEmailService()
        {
            using var scope = _scopeFactory.CreateScope();
            return scope.ServiceProvider.GetService<IEmailService>();
        }

    }
        
    }
