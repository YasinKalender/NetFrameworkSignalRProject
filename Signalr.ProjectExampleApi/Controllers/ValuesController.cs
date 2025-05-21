using Microsoft.AspNet.SignalR;
using Signalr.ProjectExampleApi.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Signalr.ProjectExampleApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("api/sendmessage")]
        public IHttpActionResult SendMessageToClients()
        {

            var context = GlobalHost.ConnectionManager.GetHubContext<MyHub>();

            context.Clients.All.receiveMessage("Merhaba client!");

            return Ok("Mesaj gönderildi");
        }


    }
}
