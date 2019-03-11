using System.Collections.Generic;
using TwitterSupport.Model.Support;

namespace TwitterSupport.Services.TweetService
{
    public interface ITreatmentTweetService
    {
        List<TweetMostRelevant> SelectOrderedMostRelevantTweets();

        List<TweetMostMentions> SelectOrderedMostMentionedTweets();
    }
}