using System.Threading.Tasks;

namespace Vigilantes.DaprWorkshop.OrderService.Services
{
  public interface IEventPublish
  {
    Task PublishEventAsync<T>(string pubSubName, string topicName, T message);
  }
}

