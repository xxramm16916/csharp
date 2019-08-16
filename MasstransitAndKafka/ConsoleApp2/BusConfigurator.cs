using MassTransit;
using MassTransit.RabbitMqTransport;
using System;

namespace Send
{
    public static class BusConfigurator
    {
        public static IBusControl ConfigureBus(Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> 
                                               registrationAction = null)
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
           {
               var host = cfg.Host(new Uri(RabbitMQConstants.RabbitMQUri), hst =>
               {
                   hst.Username(RabbitMQConstants.UserName);
                   hst.Password(RabbitMQConstants.Password);
               });

               registrationAction?.Invoke(cfg, host);
           });
        }

    }
}
