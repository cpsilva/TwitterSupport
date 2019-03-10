using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using TwitterSupport.Model.Support;
using TwitterSupport.Model.Tweet;

namespace TwitterSupport.Services.TweetService
{
    public class TweetService : ITweetService
    {
        public TweetRoot GetTweets()
        {
            var request = WebRequest.Create("http://tweeps.locaweb.com.br/tweeps");
            request.Headers.Add("Username", "caiopirees@gmail.com");
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";

            var response = (HttpWebResponse)request.GetResponse();

            var streamResponse = new StreamReader(response.GetResponseStream());

            var jsonResponse = streamResponse.ReadToEnd();

            return JsonConvert.DeserializeObject<TweetRoot>(jsonResponse);
        }

        private IEnumerable<TweetSupport> ConvertTweetRootToTweetSupport(TweetRoot tweetRoot)
        {
            var result = tweetRoot.statuses.Where(x => x.entities.user_mentions.Any(y => y.id == 42) && (x.in_reply_to_user_id != 42 || x.in_reply_to_user_id == null));

            return result.Select(x => new TweetSupport
            {
                Username = x.user.screen_name,
                Followers = x.user.followers_count,
                Retweets = x.retweet_count,
                TweetFavorites = x.favorite_count,
                Date = x.created_at,
                Tweet = x.text,
                TweetLink = x.entities.urls.Select(y => new Urls { expanded_url = y.expanded_url }),
                ProfileLink = null
            });
        }

        public List<IGrouping<string, TweetSupport>> SelectOrderedMostMentionedTweets()
        {
            var tweets = GetTweets();

            var tweetsSupport = ConvertTweetRootToTweetSupport(tweets);

            return tweetsSupport.GroupBy(x => x.Username).Select(x => x).ToList();
        }

        public List<TweetSupport> SelectOrderedMostRelevantTweets()
        {
            var tweets = GetTweets();

            var tweetsSupport = ConvertTweetRootToTweetSupport(tweets);

            return tweetsSupport.OrderByDescending(x => x.Followers).ToList();
        }
    }
}