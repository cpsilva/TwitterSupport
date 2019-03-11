using TwitterSupport.Model.Tweet;

namespace TwitterSupport.Services.TweetService
{
    public interface ITweetService
    {
        TweetRoot GetTweets();
    }
}