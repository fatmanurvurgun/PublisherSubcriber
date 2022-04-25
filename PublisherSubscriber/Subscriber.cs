using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherSubscriber
{
    public class Subscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }
        public void Subscribe(Publisher p)
        {
            p.OnPublish += OnNotificationReceived;
        }

        public void UnSubscribe(Publisher p)
        {
            p.OnPublish -= OnNotificationReceived;
        }

        protected virtual void OnNotificationReceived(Publisher p, NotificationEventArgs e)
        {
            Console.WriteLine("Hello, " + Name +"." + e.Message + "from " + p.ChannelName + " at " + e.CreatedDate);
        }
    }
}
