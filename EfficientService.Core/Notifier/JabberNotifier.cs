using System.Threading;
using EfficientService.Core.Entities;
using jabber.client;

namespace EfficientService.Core.Notifier
{
    public class JabberNotifier : INotifier
    {
        private readonly string _message;
        private readonly User _to;

        public JabberNotifier(string message, User to)
        {
            _message = message;
            _to = to;
        }

        public void Notify()
        {
            var settings = EsFacade.Settings;
            string server = settings["JabberServer"];
            string login = settings["JabberLogin"];
            string pass = settings["JabberPassword"];

            if (!Validator.HasValue(server, login, pass))
            {
                EsFacade.Logger.Warn("Jabber settings not properly configured.");
                return;
            }

            // we will wait on this event until we're done sending
            ManualResetEvent done = new ManualResetEvent(false);

            JabberClient j = new JabberClient
            {
                User = login,
                Server = server,
                Password = pass,
                AutoPresence = false,
                AutoRoster = false,
                AutoReconnect = -1
            };

            // listen for errors.  Always do this!
            j.OnError += (o, ex) =>
            {
                EsFacade.Logger.Error("Jabber notification error.", ex.Message);
                done.Set();
            };

            // what to do when login completes
            j.OnAuthenticate += o =>
            {
                JabberClient client = (JabberClient)o;
                client.Message(_to.Jabber, _message);
                done.Set();
            };

            // Set everything in motion
            j.Connect();

            // wait until sending a message is complete
            done.WaitOne();

            // logout cleanly
            j.Close();
        }
    }
}