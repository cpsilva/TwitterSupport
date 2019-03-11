using System.Collections.Generic;
using System.Linq;
using TwitterSupport.Model.Support;
using TwitterSupport.Model.Tweet;

namespace TwitterSupport.Services.TweetService
{
    public class TreatmentTweetService : ITreatmentTweetService
    {
        private readonly ITweetService _tweetService;

        public TreatmentTweetService(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }

        private IEnumerable<TweetMostRelevant> ConvertTweetRootToTweetSupport(TweetRoot tweetRoot)
        {
            if (tweetRoot.statuses.Any(x => x.entities == null))
            {
                return new List<TweetMostRelevant>();
            }
            var result = tweetRoot.statuses.Where(x => x.entities.user_mentions.Any(y => y.id == 42) && (x.in_reply_to_user_id != 42 || x.in_reply_to_user_id == null));

            return result.Select(x => new TweetMostRelevant
            {
                Username = x.user.screen_name,
                Followers = x.user.followers_count,
                Retweets = x.retweet_count,
                TweetFavorites = x.favorite_count,
                Date = x.created_at,
                Tweet = x.text,
                TweetLink = x.entities.urls.Select(y => new Urls { expanded_url = y.expanded_url }),
                ProfileLink = null
            }).OrderByDescending(x => x.Followers).ThenByDescending(x => x.Retweets).ThenByDescending(x => x.TweetFavorites);
        }

        public List<TweetMostMentions> SelectOrderedMostMentionedTweets()
        {
            var tweets = _tweetService.GetTweets();

            var tweetsSupport = ConvertTweetRootToTweetSupport(tweets);

            return tweetsSupport.GroupBy(x => x.Username).Select(x => new TweetMostMentions
            {
                Username = x.Key,
                Tweets = x
            }).ToList();
        }

        public List<TweetMostRelevant> SelectOrderedMostRelevantTweets()
        {
            var tweets = _tweetService.GetTweets();

            var tweetsSupport = ConvertTweetRootToTweetSupport(tweets);

            return tweetsSupport.ToList();
        }
    }
}