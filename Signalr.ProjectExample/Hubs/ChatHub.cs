using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace Signalr.ProjectExample.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string userName, string message)
        {
            Clients.All.broadcastMessage(userName, message);
        }

        public void SendContractNotification(string userId, string message)
        {
          
            Clients.User(userId).receiveContractNotification(message);
        }

        public void SendContractNotification(string message)
        {

            Clients.All.receiveContractNotification(message);
        }


        public override Task OnConnected()
        {
            var userId = "Yasin Kalender"; 
            return base.OnConnected();
        }
    }
}