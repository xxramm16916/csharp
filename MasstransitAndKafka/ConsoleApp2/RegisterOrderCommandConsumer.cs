using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;
using Contract;

namespace ConsoleApp2
{
    public class RegisterOrderCommandConsumer : IConsumer<IRegisterOrderCommand>
    {
        public async Task Consume(ConsumeContext<IRegisterOrderCommand> context)
        {
            await Console.Out.WriteLineAsync($"Message {context.Message.Name} registered");
        }
    }

}
