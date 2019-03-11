using System.Collections.Generic;
using TwitterSupport.Model.Tweet;

namespace TwitterSupport.Model.Support
{
    public class TweetMostRelevant
    {
        public string Username { get; set; }
        public int Followers { get; set; }
        public int Retweets { get; set; }
        public int TweetFavorites { get; set; }
        public string Tweet { get; set; }
        public string Date { get; set; }
        public string ProfileLink { get; set; }
        public IEnumerable<Urls> TweetLink { get; set; }
    }
}