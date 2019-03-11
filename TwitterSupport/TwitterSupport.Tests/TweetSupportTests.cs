using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwitterSupport.Services.TweetService;

namespace TwitterSupport.Tests
{
    [TestClass]
    public class TweetSupportTests
    {
        private ITreatmentTweetService _treatmentTweet { get; }

        public TweetSupportTests()
        {
            var services = new ServiceCollection();
            services.AddScoped<ITweetService, TweetService>();
            services.AddScoped<ITreatmentTweetService, TreatmentTweetService>();
            _treatmentTweet = services.BuildServiceProvider().GetRequiredService<ITreatmentTweetService>();
        }

        [TestMethod]
        public void Teste()
        {
        }
    }
}