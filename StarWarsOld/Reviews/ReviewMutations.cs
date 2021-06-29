using System;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Subscriptions;
using StarWars.Repositories;

namespace StarWars.Reviews
{
    //[ExtendObjectType(Name = "Mutation")]
    [HotChocolate.Types.ExtendObjectType("Mutation")]
    public class ReviewMutations
    {
        /// <summary>
        /// Creates a review for a given Star Wars episode.
        /// </summary>
        public async Task<CreateReviewPayload> CreateReview(
            CreateReviewInput input,
            [Service]IReviewRepository repository,
            [Service] ITopicEventSender eventSender)
        {
            var review = new Review(input.Stars, input.Commentary);
            repository.AddReview(input.Episode, review);

            await eventSender.SendAsync("ReviewCreated", review);

            return new CreateReviewPayload(input.Episode, review, DateTime.Now);
        }
    }
}