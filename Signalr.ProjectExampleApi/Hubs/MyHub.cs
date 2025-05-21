using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Signalr.ProjectExampleApi.Hubs
{
    public class MyHub : Hub
    {
        public void SendMessage(string message)
        {
            Clients.All.receiveMessage(message);
        }
    }
}