using System;
using Messages;
using NServiceBus;

namespace MsmqEndpoint
{
    public class HandleTestEventA : IHandleMessages<TestEventA>
    {
        public void Handle(TestEventA message)
        {
            Console.WriteLine("Received: " + message.Message);
        }
    }
}