﻿namespace Messages
{
    using NServiceBus;

    public class TestEvent : IEvent
    {
        public string Message;
    }
}