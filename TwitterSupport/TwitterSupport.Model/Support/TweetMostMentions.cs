using System.Collections.Generic;

namespace TwitterSupport.Model.Support
{
    public class TweetMostMentions
    {
        public string Username { get; set; }
        public IEnumerable<TweetMostRelevant> Tweets { get; set; }
    }
}