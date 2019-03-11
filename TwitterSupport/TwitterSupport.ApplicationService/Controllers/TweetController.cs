using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TwitterSupport.Model.Support;
using TwitterSupport.Services.TweetService;

namespace TwitterSupport.ApplicationService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TweetController : ControllerBase
    {
        public ITweetService _tweetService { get; set; }

        public TweetController(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }

        [HttpGet]
        [Route("MostMentions")]
        public List<TweetMostMentions> MostMentions()
        {
            return _tweetService.SelectOrderedMostMentionedTweets();
        }

        [HttpGet]
        [Route("MostRelevant")]
        public List<TweetMostRelevant> MostRelevant()
        {
            return _tweetService.SelectOrderedMostRelevantTweets();
        }
    }
}