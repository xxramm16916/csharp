using MassTransit;
using System;

namespace massTransitProg
{
    class Program
    {

        public class YourMessage
        {
            public string Text { get; set; }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Создаем Шину

            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                var host = sbc.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                sbc.ReceiveEndpoint(host, "test_queue", ep =>
                {
                    ep.Handler<YourMessage>(context =>
                    {
                        return Console.Out.WriteLineAsync($"Received: {context.Message.Text}");
                    });
                });
            });
            /*
            IBusControl bus = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri("rabbitmq://localhost"), host =>
                {
                    host.Username("guest");
                    host.Password("guest");
                });
            });
            bus.Start();
            
            var line = Console.ReadLine();
            bus.Publish(line);
            Console.WriteLine("Hello World!");
            */
        }
    }
}
