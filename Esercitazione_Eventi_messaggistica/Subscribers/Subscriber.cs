using Esercitazione_Eventi_messaggistica.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_Eventi_messaggistica.Subscribers
{
    public class Subscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void Subscribe(IPublisher p)
        {
            p.OnPublish += OnNotificationReceived;
        }

        public void OnNotificationReceived(IPublisher p, Notification n, string provider, bool isGroup)
        {
            Console.WriteLine($"Ciao {Name}, {n.Message}, alle ore {n.Now} {p.ToString()}");
        }

    }
}
