using System;
using System.Collections.Generic;
using System.Text;

namespace ReciveMassTransit
{
    class SomethingHappenedMessage : SomethingHappened
    {
        public string What { get; set; }
        public DateTime When { get; set; }
    }
}
