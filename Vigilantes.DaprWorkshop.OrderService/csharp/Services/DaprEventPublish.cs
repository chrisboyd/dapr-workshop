using System.Threading;
using System.Threading.Tasks;
using Dapr.Client;

namespace Vigilantes.DaprWorkshop.OrderService.Services
{
    public class DaprEventPublish : IEventPublish
    {
        public async Task PublishEventAsync<T>(string pubSubName,string topicName,T message)
        {
            var source = new CancellationTokenSource();
            var cancellationToken = source.Token;

            using var client = new DaprClientBuilder().Build();
            await client.PublishEventAsync(pubSubName, topicName, message, cancellationToken);
        }
    }
}