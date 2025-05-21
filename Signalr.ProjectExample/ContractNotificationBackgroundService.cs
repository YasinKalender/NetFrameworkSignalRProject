using Microsoft.AspNet.SignalR;
using Signalr.ProjectExample.Hubs;
using System;
using System.Threading;

namespace Signalr.ProjectExample
{
    public class ContractNotificationBackgroundService
    {
        private Timer _timer;
        private readonly TimeSpan _dueTime = TimeSpan.Zero;
        private readonly TimeSpan _period = TimeSpan.FromSeconds(5); 

        public void Start()
        {
            _timer = new Timer(SendContractNotification, null, _dueTime, _period);
        }

        private void SendContractNotification(object state)
        {
        
            string message = "Lütfen sözleşmenizi imzalayın.";

            var context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();  
            context.Clients.All.receiveContractNotification(message); 

            Console.WriteLine("Bildirim gönderildi: " + message);
        }

        public void Stop()
        {
            _timer?.Dispose();
        }
    }
}