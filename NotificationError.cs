using System;

namespace Notification
{
    public class NotificationError
    {
        public string message { get; private set; }
        public NotificationError(string message) 
        {
            this.message = message;
        }
    }
}