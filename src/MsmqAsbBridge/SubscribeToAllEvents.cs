using NServiceBus;
using NServiceBus.Settings;
using NServiceBus.Transports;

namespace AsbMsmqBridge
{
    using Messages;

    public class SubscribeToAllEvents : IWantToRunWhenBusStartsAndStops
    {
        private readonly IManageSubscriptions _subscriptionManager;

        public SubscribeToAllEvents(IManageSubscriptions subscriptionManager)
        {
            _subscriptionManager = subscriptionManager;
        }

        public void Start()
        {
            _subscriptionManager.Subscribe(typeof(TestEventA), Address.Parse("MsmqEndpoint@localhost"));
        }

        public void Stop()
        {
        }
    }
}