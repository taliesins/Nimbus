using System;

namespace Nimbus.Configuration
{
    public interface IPathFactoryProvider
    {
        string InputQueuePathFor(string applicationName, string instanceName);
        string QueuePathFor(Type type);
        string TopicPathFor(Type type);
        string SubscriptionNameFor(string applicationName);
        string SubscriptionNameFor(string applicationName, string instanceName);
        string SubscriptionNameFor(string applicationName, Type handlerType);
        string SubscriptionNameFor(string applicationName, string instanceName, Type handlerType);
    }
}