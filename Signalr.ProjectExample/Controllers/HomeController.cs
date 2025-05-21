using Microsoft.AspNet.SignalR;
using Signalr.ProjectExample.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Signalr.ProjectExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void NotifyUnSignedContracts()
        {
            string message = "Lütfen sözleşmenizi imzalayın.";

            var context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            context.Clients.All.receiveContractNotification(message);
        }
    }
}