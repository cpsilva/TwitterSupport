using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using TwitterSupport.Model.Tweet;

namespace TwitterSupport.Services.TweetService
{
    public class TweetService : ITweetService
    {
        private readonly IConfiguration _configuration;

        public TweetService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TweetRoot GetTweets()
        {
            var request = WebRequest.Create(_configuration.GetSection("Url").Value);
            request.Headers.Add(_configuration.GetSection("HTTP_USERNAME").Value, _configuration.GetSection("Value").Value);
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";

            var response = (HttpWebResponse)request.GetResponse();

            var streamResponse = new StreamReader(response.GetResponseStream());

            var jsonResponse = streamResponse.ReadToEnd();

            return JsonConvert.DeserializeObject<TweetRoot>(jsonResponse);
        }
    }
}