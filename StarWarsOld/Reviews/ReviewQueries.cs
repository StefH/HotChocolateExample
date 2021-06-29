using System.Collections.Generic;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using StarWars.Characters;
using StarWars.Repositories;

namespace StarWars.Reviews
{
    [HotChocolate.Types.ExtendObjectType("Query")]
    public class ReviewQueries
    {
        //[UsePaging]
        [UseFiltering]
        [UseSorting]
        public IEnumerable<Review> GetReviews(Episode episode, [Service] IReviewRepository repository) => repository.GetReviews(episode);
    }
}
