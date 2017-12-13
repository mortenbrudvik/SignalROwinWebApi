using System;
using System.Web.Http;
using WebApiServerConsole.Hubs;

namespace WebApiServerConsole.Controllers
{
    public class MessageController : ApiController
    {
        public string Get()
        {
            MessageHub.SendMessageToClients("api/message has been called");

            return "hello";
        }
    }
}