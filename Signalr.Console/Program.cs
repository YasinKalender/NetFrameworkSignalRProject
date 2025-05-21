using Microsoft.AspNet.SignalR.Client;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Signalr.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnection("https://localhost:44345/signalr");

            // Hub'a bağlan
            IHubProxy hubProxy = connection.CreateHubProxy("myHub");

    
            connection.Start().ContinueWith(task =>
            {
                if (task.IsCompleted)
                    System.Console.WriteLine("Connected");
                else
                    System.Console.WriteLine("Connection failed: " + task.Exception?.Message);
            }).Wait();

            hubProxy.On<string>("receiveMessage", (name) =>
            {
                System.Console.WriteLine($"Received message:{name} ");
            });


            System.Console.ReadLine();
        }

     
    }
}
