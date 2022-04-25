using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherSubscriber
{
    public class Publisher
    {
        public string ChannelName { get; set; }

        public delegate void NotifyEventHandler(Publisher publisher, NotificationEventArgs e);

        public event NotifyEventHandler OnPublish;

        public Publisher(string channelName)
        {
            ChannelName = channelName;
        }
        public void Publish()
        {
            if (OnPublish != null)
            {
                NotificationEventArgs notificationEventArgs = new NotificationEventArgs(DateTime.Now, " You have a new notification ");
                OnPublish(this, notificationEventArgs);
            }
        }
    }
}
