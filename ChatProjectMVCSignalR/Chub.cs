using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatProjectMVCSignalR
{
    public class Chub : Hub
    {
        public void Send(string username, string message)
        {
            Clients.All.sendMessage(username,message);
        }
    }
}