namespace Messages
{
    using NServiceBus;

    public class TestCommand : ICommand
    {
        public string Hello { get; set; }
        public string IAm { get; set; }
    }
}
