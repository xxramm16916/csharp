using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MassTransit;


namespace RabbitMQ
{
    class Program
    {

        public static void Send(string message)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    //queue
                    channel.QueueDeclare(queue: "firstQueue",
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);
                    //message
                    var body = Encoding.UTF8.GetBytes(message);

                    //exchange
                    channel.BasicPublish(exchange: "",
                                        routingKey: "firstQueue",
                                        basicProperties: null,
                                        body: body);
                    Console.WriteLine("Sent {0}", message);
                }
            }
        }
        public class YourMessage
        {
            public string Text { get; set; }
        }
        static void Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                var host = sbc.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                //sbc.ReceiveEndpoint(host, "test_queue", ep =>
                //{
                    //ep.Handler<YourMessage>(context =>
                    //{
                        //return Console.Out.WriteLineAsync($"Received: {context.Message.Text}");
                    //});
                //});
            });

            bus.Start(); // This is important!

            bus.Publish(new YourMessage { Text = "Hi" });

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            bus.Stop();



            //List<string> messages = new List<string>{ "first", "second", "third", "lastMessage"};
            //foreach(string message in messages)
            //{
            //   Console.WriteLine(message);
            //   Send(message);
            //  Thread.Sleep(1000);
            //}
        }
    }
}
