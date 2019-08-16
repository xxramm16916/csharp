using GreenPipes;
using MassTransit;
using Send;
using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(6000);
            Console.WriteLine("Listening");

            var bus = Bus.Factory.CreateUsingRabbitMq(cfg =>
                {
                    //cfg.UseJsonSerializer();
                    //cfg.UseExceptionLogger();
                    //cfg.UseRetry(Retry.Immediate(2));
                    //cfg.PrefetchCount = 100;
                    var host = cfg.Host(new Uri(RabbitMQConstants.RabbitMQUri), hst =>
                    {
                        hst.Username(RabbitMQConstants.UserName);
                        hst.Password(RabbitMQConstants.Password);
                    });

                    cfg.ReceiveEndpoint(host, RabbitMQConstants.RegisterOrderServiceQueue, e =>
                    {
                        e.Consumer<RegisterOrderCommandConsumer>();
                    });
                });

            bus.Start();

            Console.ReadKey();

            bus.Stop();

        }
    }
}
