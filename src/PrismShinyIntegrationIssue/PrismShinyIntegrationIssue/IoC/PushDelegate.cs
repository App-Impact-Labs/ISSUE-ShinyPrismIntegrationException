using Shiny.Push;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrismShinyIntegrationIssue.IoC
{
    public class DefaultPushDelegate : IPushDelegate
    {
        public virtual async Task OnEntry(PushNotification data)
        {
        }

        public virtual async Task OnReceived(PushNotification data)
        {
        }

        public virtual async Task OnTokenRefreshed(string token)
        {
        }
    }
}
