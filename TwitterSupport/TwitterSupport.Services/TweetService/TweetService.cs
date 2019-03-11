using Newtonsoft.Json;
using System.IO;
using System.Net;
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
    }
}