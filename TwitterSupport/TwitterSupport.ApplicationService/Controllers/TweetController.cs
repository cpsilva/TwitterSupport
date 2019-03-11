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
        public ITreatmentTweetService _treatmentTweetService { get; set; }

        public TweetController(ITreatmentTweetService treatmentTweetService)
        {
            _treatmentTweetService = treatmentTweetService;
        }

        [HttpGet]
        [Route("MostMentions")]
        public List<TweetMostMentions> MostMentions()
        {
            return _treatmentTweetService.SelectOrderedMostMentionedTweets();
        }

        [HttpGet]
        [Route("MostRelevant")]
        public List<TweetMostRelevant> MostRelevant()
        {
            return _treatmentTweetService.SelectOrderedMostRelevantTweets();
        }
    }
}