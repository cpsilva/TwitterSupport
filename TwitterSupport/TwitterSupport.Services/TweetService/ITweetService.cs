using System.Collections.Generic;
using System.Linq;
using TwitterSupport.Model.Support;
using TwitterSupport.Model.Tweet;

namespace TwitterSupport.Services.TweetService
{
    public interface ITweetService
    {
        TweetRoot GetTweets();

        List<TweetSupport> SelectOrderedMostRelevantTweets();

        List<IGrouping<string, TweetSupport>> SelectOrderedMostMentionedTweets();
    }
}