using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebApiServerConsole.Hubs
{
    [HubName("messageHub")]
    public class MessageHub : Hub
    {
        public static void SendMessageToClients(string message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<MessageHub>();
            context.Clients.All.messageRecieved(message);
        }
    }
}