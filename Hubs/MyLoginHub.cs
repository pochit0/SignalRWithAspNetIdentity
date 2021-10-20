using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRWithAspNetIdentity.Hubs
{
    public class MyLoginHub : Hub
    {
        public async Task LogInUser(string username)
        {
            await Clients.All.SendAsync("UserHasLoggedIn", username);
        }
    }
}