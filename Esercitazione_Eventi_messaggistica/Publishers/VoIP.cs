using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Esercitazione_Eventi_messaggistica.Publishers.IPublisher;

namespace Esercitazione_Eventi_messaggistica.Publishers
{
    internal class VoIP : IPublisher
    {
        public string PublisherName { get; set; }

        public event Notify OnPublish;

        public void Publish(string sender)
        {
            if (OnPublish != null)
            {
                Notification notifica = new Notification("messaggio ricevuto ", sender,  DateTime.Now);
                OnPublish(this, notifica);
            }
        }
    }
}
