using System;
using EfficientService.Core.Entities;

namespace EfficientService.Core.Notifier
{
    public class NotifyManager
    {
        private readonly string _message;
        private readonly User _to;

        public NotifyManager(string message, User to)
        {
            _message = message;
            _to = to;
        }

        // TODO: Implement read config and load notify modules
        public void Notify()
        {
            var settings = EsFacade.Settings;
            if (Convert.ToBoolean(settings["IsJabberEnabled"]) == false) return;
            
            // read config
            
            JabberNotifier jabberNotifier = new JabberNotifier(_message, _to);
            jabberNotifier.Notify();
        }
    }
}