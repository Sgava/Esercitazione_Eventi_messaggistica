using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_Eventi_messaggistica.Publishers
{
    public interface IPublisher
    {
        public string PublisherName { get; set; }

        // delegato comune

        public delegate void Notify(IPublisher p, Notification notification, string provider = "", bool isGroup = false);

        public event Notify OnPublish;

        public void Publish(string sender);
    }
}
