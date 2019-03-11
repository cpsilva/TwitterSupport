using System.Collections.Generic;
using TwitterSupport.Model.Support;
using TwitterSupport.Model.Tweet;

namespace TwitterSupport.Services.TweetService
{
    public interface ITweetService
    {
        TweetRoot GetTweets();

        List<TweetMostRelevant> SelectOrderedMostRelevantTweets();

        List<TweetMostMentions> SelectOrderedMostMentionedTweets();
    }
}