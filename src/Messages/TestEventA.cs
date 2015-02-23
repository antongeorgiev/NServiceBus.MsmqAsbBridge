namespace Messages
{
    using NServiceBus;

    public class TestEventA : IEvent
    {
        public string Message;
    }
}