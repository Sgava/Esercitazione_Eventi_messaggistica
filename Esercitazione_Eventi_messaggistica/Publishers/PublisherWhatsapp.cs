using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_Eventi_messaggistica.Publishers
{
    internal class PublisherWhatsapp : IPublisher
    {
        public string PublisherName { get; set; }

        public bool IsGroup { get; set; }   

        public PublisherWhatsapp(string name,bool group)
        {
            PublisherName = name;
            IsGroup = group;
        }

        public event IPublisher.Notify OnPublish;

        public void Publish(string sender)
        {
            if (OnPublish != null)
            {
                Notification notifica = new Notification($"messaggio ricevuta da {sender}", sender, DateTime.Now);
                OnPublish(this, notifica,"", IsGroup);
            }
        }

        public override string ToString()
        {
            if(IsGroup)
            {
                return $"\nDa un gruppo";
            }
            else
            {
                return $"";
            }
        }
    }
}
