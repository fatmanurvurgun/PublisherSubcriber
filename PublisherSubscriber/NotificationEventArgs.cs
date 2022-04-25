using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherSubscriber
{
    public class NotificationEventArgs
    {
        public string Message { get; set; }

        public DateTime CreatedDate { get; set; }

        public NotificationEventArgs(DateTime createdDate, string message)
        {
            Message = message;
            CreatedDate = createdDate;
        }
    }
}
