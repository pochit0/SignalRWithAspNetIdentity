using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRWithAspNetIdentity.Hubs
{
    public interface ILoginHub
    {
        Task ReceiveMessage(string user, string message);
    }

    public class LoginHub : Hub<ILoginHub>
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.ReceiveMessage(user, message);
        }
    }
}