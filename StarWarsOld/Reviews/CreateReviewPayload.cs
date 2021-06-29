using System;
using StarWars.Characters;

namespace StarWars.Reviews
{
    public class CreateReviewPayload
    {
        public CreateReviewPayload(Episode episode, Review review, DateTime dateTime)
        {
            Episode = episode;
            Review = review;
            DateTime = dateTime;
        }

        public Episode Episode { get; }

        public Review Review { get; }

        public DateTime DateTime { get;  }
    }
}
