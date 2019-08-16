using MassTransit;
using System;
using System.Threading.Tasks;

namespace ReciveMassTransit
{
    class Program
    {
        public interface ValueEntered
        {
            string Value { get; }
        }

        static void Main(string[] args)
        {
            Sender();
        }



        public static void Receiever()
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri("rabbitmq://localhost/"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                string queueName = "hello";

                cfg.ReceiveEndpoint(host, queueName, e =>
                {
                    e.Consumer<UpdateCustomerConsumer>();
                });
            });
        }

        public static void Sender()
        {
            var busControl = ConfigureBus();
            busControl.Start();

            do
            {
                Console.WriteLine("Enter message (or quit to exit)");
                Console.Write("> ");
                string value = Console.ReadLine();

                if ("quit".Equals(value, StringComparison.OrdinalIgnoreCase))
                    break;

                busControl.Publish<ValueEntered>(new
                {
                    Value = value
                });
            }
            while (true);

            busControl.Stop();
        }

        static IBusControl ConfigureBus()
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });
            });
        }
    }
}
