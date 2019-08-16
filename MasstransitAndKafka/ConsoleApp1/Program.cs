using Send;
using System;
using System.Threading;
using System.Threading.Tasks;
using Contract;

namespace ConsoleApp1
{
    
    class Program
    {

        public static async Task SendMessage()
        {
            var bus = BusConfigurator.ConfigureBus();
            var sendToUri = new Uri($"{RabbitMQConstants.RabbitMQUri}" + $"{RabbitMQConstants.RegisterOrderServiceQueue}");
            var endpoint = await bus.GetSendEndpoint(sendToUri);
           
            await endpoint.Send<IRegisterOrderCommand>(new
            {
                Name = "MyFirstMessage"
            });

            await endpoint.Send<IRegisterOrderCommand>(new
            {
                Name = "MySecondMessage"
            });
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task starting!");            
            SendMessage().Wait();
            Console.WriteLine("Message sent!");
            Console.ReadKey();
        }
    }
}
