using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_Eventi_messaggistica.Publishers
{
    internal class PublisherEmail : IPublisher
    {
        public string PublisherName { get ; set; }

        public string Provider { get; set; }

        public event IPublisher.Notify OnPublish;

        public PublisherEmail(string provider, string name)
        {
            PublisherName = provider;
            Provider = name;
        }

        public void Publish(string sender)
        {
            if (OnPublish != null)
            {
                Notification notifica = new Notification($"mail ricevuta da {sender}", sender, DateTime.Now);
                OnPublish(this, notifica, Provider);
            }
        }

        public override string ToString()
        {
            return $"Mail mandata usando {Provider}";
        }
    }
}
