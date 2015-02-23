namespace Messages
{
    using NServiceBus;

    public class TestReply : IMessage
    {
        public string Message;
    }
}