using System;
using System.Threading;
using Confluent.Kafka;

namespace ConsumerKafka
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(6000);

            var conf = new ConsumerConfig
            {
                GroupId = "test-consumer-group", //test-topic
                BootstrapServers = "localhost:9092",
                AutoOffsetReset = AutoOffsetReset.Earliest //смещение по журналу, начиная с первого сообщения
            };

            using (var c = new ConsumerBuilder<Ignore, string>(conf).Build())
            {
                c.Subscribe("test-topic");

                CancellationTokenSource cts = new CancellationTokenSource();
                Console.CancelKeyPress += (_, e) => {
                    e.Cancel = true; 
                    cts.Cancel();
                };

                try
                {
                    while(true)
                    {
                        try
                        {
                            var cr = c.Consume(cts.Token);
                            Console.WriteLine($"Consumed message {cr.Value} at {cr.TopicPartitionOffset}");
                        }
                        catch(ConsumeException e)
                        {
                            Console.WriteLine($"Error {e.Error.Reason}");
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    c.Close();
                }
            }
        }
    }
}
