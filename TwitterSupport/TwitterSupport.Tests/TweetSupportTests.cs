using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
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
            var moq = new Mock<ITweetService>();
            moq.Setup(x => x.GetTweets()).Returns(() => new Model.Tweet.TweetRoot
            {
                statuses = new System.Collections.Generic.List<Model.Tweet.TweetJSON>
                {
                    new Model.Tweet.TweetJSON
                    {
                        contributors = null,
                        coordinates = null,
                        created_at = "Mon Sep 24 03:35:21 +0000 2012",
                        //entities = new Model.Tweet.Entities
                        //{
                        //    hashtags = {object[0]},
                        //    urls = {Model.Tweet.Urls[0]},
                        //    user_mentions = {Model.Tweet.UserMentions[0]}
                        //},
                        favorite_count = 256,
                        favorited = true,
                        geo = null,
                        id = 331454,
                        id_str = "331454",
                        in_reply_to_screen_name = "",
                        in_reply_to_status_id = null,
                        in_reply_to_status_id_str = "",
                        in_reply_to_user_id = null,
                        in_reply_to_user_id_str = "",
                        metadata = new Model.Tweet.Metadata
                        {
                            iso_language_code = "pt",
                            result_type = "recent"
                        },
                        place = null,
                        retweet_count = 4,
                        retweeted = true,
                        source = "web",
                        text = "If we calculate the system, we can get to the SMTP feed through the back-end XML monitor!",
                        truncated = false,
                        user = new Model.Tweet.User
                        {
                            _protected = false,
                            contributors_enabled = false,
                            created_at = "Mon Apr 26 06:01:55 +0000 2010",
                            default_profile = true,
                            default_profile_image = false,
                            description = "Born 330 Live 310",
                            favourites_count = 37,
                            follow_request_sent = null,
                            followers_count = 738,
                            following = null,
                            friends_count = 738,
                            geo_enabled = true,
                            id = 232540,
                            id_str = "232540",
                            is_translator = false,
                            lang = "en",
                            listed_count = 2,
                            location = "LA, CA",
                            name = "Haag Regan",
                            notifications = null,
                            profile_background_color = "C0DEED",
                            profile_background_image_url = "http://a0.twimg.com/images/themes/theme1/bg.png",
                            profile_background_image_url_https = "https://si0.twimg.com/images/themes/theme1/bg.png",
                            profile_background_tile = false,
                            profile_image_url = "http://a0.twimg.com/profile_images/2359746665/1v6zfgqo8g0d3mk7ii5s_normal.jpeg",
                            profile_image_url_https = "https://si0.twimg.com/profile_images/2359746665/1v6zfgqo8g0d3mk7ii5s_normal.jpeg",
                            profile_link_color = "0084B4",
                            profile_sidebar_border_color = "C0DEED",
                            profile_sidebar_fill_color = "DDEEF6",
                            profile_text_color = "333333",
                            profile_use_background_image = true,
                            screen_name = "haag_regan",
                            show_all_inline_media = false,
                            statuses_count = 579,
                            time_zone = "Pacific Time (US & Canada)",
                            url = null,
                            utc_offset = -28800,
                            verified = false
                        }
                    },
                    new Model.Tweet.TweetJSON
                    {
                        contributors = null,
                        coordinates = null,
                        created_at = "Mon Sep 24 03:35:21 +0000 2012",
                        //entities = new TwitterSupport.Model.Tweet.Entities
                        //{
                        //    hashtags = {object[0]},
                        //    urls = {Model.Tweet.Urls[0]},
                        //    user_mentions = {Model.Tweet.UserMentions[0]}
                        //},
                        favorite_count = 0,
                        favorited = false,
                        geo = null,
                        id = 582206,
                        id_str = "582206",
                        in_reply_to_screen_name = "",
                        in_reply_to_status_id = null,
                        in_reply_to_status_id_str = "",
                        in_reply_to_user_id = null,
                        in_reply_to_user_id_str = "",
                        metadata = new Model.Tweet.Metadata
                        {
                            iso_language_code = "pt",
                            result_type = "recent"
                        },
                        place = null,
                        retweet_count = 0,
                        retweeted = false,
                        source = "web",
                        text = "Transmitting the transmitter won't do anything, we need to back up the mobile pci panel!",
                        truncated = false,
                        user = new Model.Tweet.User
                        {
                            _protected = false,
                            contributors_enabled = false,
                            created_at = "Mon Apr 26 06:01:55 +0000 2010",
                            default_profile = true,
                            default_profile_image = false,
                            description = "Born 330 Live 310",
                            favourites_count = 37,
                            follow_request_sent = null,
                            followers_count = 452,
                            following = null,
                            friends_count = 452,
                            geo_enabled = true,
                            id = 189964,
                            id_str = "189964",
                            is_translator = false,
                            lang = "en",
                            listed_count = 2,
                            location = "LA, CA",
                            name = "Ii Abbott Rowland",
                            notifications = null,
                            profile_background_color = "C0DEED",
                            profile_background_image_url = "http://a0.twimg.com/images/themes/theme1/bg.png",
                            profile_background_image_url_https = "https://si0.twimg.com/images/themes/theme1/bg.png",
                            profile_background_tile = false,
                            profile_image_url = "http://a0.twimg.com/profile_images/2359746665/1v6zfgqo8g0d3mk7ii5s_normal.jpeg",
                            profile_image_url_https = "https://si0.twimg.com/profile_images/2359746665/1v6zfgqo8g0d3mk7ii5s_normal.jpeg",
                            profile_link_color = "0084B4",
                            profile_sidebar_border_color = "C0DEED",
                            profile_sidebar_fill_color = "DDEEF6",
                            profile_text_color = "333333",
                            profile_use_background_image = true,
                            screen_name = "ii_abbott_rowland",
                            show_all_inline_media = false,
                            statuses_count = 579,
                            time_zone = "Pacific Time (US & Canada)",
                            url = null,
                            utc_offset = -28800,
                            verified = false
                        }
                    },
                    new Model.Tweet.TweetJSON
                    {
                        contributors = null,
                        coordinates = null,
                        created_at = "Mon Sep 24 03:35:21 +0000 2012",
                        //entities = new Model.Tweet.Entities
                        //{
                        //    hashtags = {object[0]},
                        //    urls = {Model.Tweet.Urls[0]},
                        //    user_mentions = {Model.Tweet.UserMentions[0]}
                        //},
                        favorite_count = 109,
                        favorited = true,
                        geo = null,
                        id = 66574,
                        id_str = "66574",
                        in_reply_to_screen_name = "",
                        in_reply_to_status_id = null,
                        in_reply_to_status_id_str = "",
                        in_reply_to_user_id = null,
                        in_reply_to_user_id_str = "",
                        metadata = new Model.Tweet.Metadata
                        {
                            iso_language_code = "pt",
                            result_type = "recent"
                        },
                        place = null,
                        retweet_count = 0,
                        retweeted = false,
                        source = "web",
                        text = "Use the virtual TCP bandwidth, then you can input the online bus!",
                        truncated = false,
                        user = new Model.Tweet.User
                        {
                            _protected = false,
                            contributors_enabled = false,
                            created_at = "Mon Apr 26 06:01:55 +0000 2010",
                            default_profile = true,
                            default_profile_image = false,
                            description = "Born 330 Live 310",
                            favourites_count = 25,
                            follow_request_sent = null,
                            followers_count = 152,
                            following = null,
                            friends_count = 152,
                            geo_enabled = true,
                            id = 123031,
                            id_str = "123031",
                            is_translator = false,
                            lang = "en",
                            listed_count = 2,
                            location = "LA, CA",
                            name = "Bria Watsica",
                            notifications = null,
                            profile_background_color = "C0DEED",
                            profile_background_image_url = "http://a0.twimg.com/images/themes/theme1/bg.png",
                            profile_background_image_url_https = "https://si0.twimg.com/images/themes/theme1/bg.png",
                            profile_background_tile = false,
                            profile_image_url = "http://a0.twimg.com/profile_images/2359746665/1v6zfgqo8g0d3mk7ii5s_normal.jpeg",
                            profile_image_url_https = "https://si0.twimg.com/profile_images/2359746665/1v6zfgqo8g0d3mk7ii5s_normal.jpeg",
                            profile_link_color = "0084B4",
                            profile_sidebar_border_color = "C0DEED",
                            profile_sidebar_fill_color = "DDEEF6",
                            profile_text_color = "333333",
                            profile_use_background_image = true,
                            screen_name = "bria_watsica",
                            show_all_inline_media = false,
                            statuses_count = 579,
                            time_zone = "Pacific Time (US & Canada)",
                            url = null,
                            utc_offset = -28800,
                            verified = false
                        }
                    }
                }
            });

            var treatmentTweetService = new TreatmentTweetService(moq.Object);

            var tweetsResult = treatmentTweetService.SelectOrderedMostRelevantTweets();

            Assert.IsTrue(tweetsResult.FirstOrDefault().Followers == 738);
        }
    }
}