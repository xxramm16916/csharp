using System;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace Send
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            using(var p = new ProducerBuilder<Null, string>(config).Build())
            {
                try
                {
                    var dr = await p.ProduceAsync("test-topic", new Message<Null, string> { Value = "test" });
                    Console.WriteLine($"Send {dr.Value} to {dr.TopicPartitionOffset}");
                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Send failed {e.Error.Reason}");
                }
            }

            Console.ReadKey();
        }
    }
}
