using System;
using System.Collections.Generic;
using System.Text;

namespace Send
{
    public static class RabbitMQConstants
    {
        public const string RabbitMQUri = "rabbitmq://localhost/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string RegisterOrderServiceQueue = "registerorder.service";
        public const string NotificationServiceQueue = "notification.service";
        public const string FinanceServiceQueue = "finance.service";
    }
}
