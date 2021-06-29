using System.Threading;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using HotChocolate.Types;

namespace StarWars.Reviews
{
    [HotChocolate.Types.ExtendObjectType("Subscription")]
    public class ReviewSubscriptions
    {
        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<Review>> OnReviewCreate([Service] ITopicEventReceiver eventReceiver, CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<string, Review>("ReviewCreated", cancellationToken);
        }
    }
}