using System.Threading.Tasks;

namespace SPMSEmails.BusServices
{
    public interface IEventProcessor
    {
        Task ProcessEvent(string message);
        
    }
}
