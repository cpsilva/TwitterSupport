namespace TwitterSupport.Model.Tweet
{
    public class TweetJSON
    {
        public object coordinates { get; set; }
        public bool favorited { get; set; }
        public bool truncated { get; set; }
        public string created_at { get; set; }
        public string id_str { get; set; }
        public Entities entities { get; set; }
        public string in_reply_to_user_id_str { get; set; }
        public object contributors { get; set; }
        public string text { get; set; }
        public Metadata metadata { get; set; }
        public int retweet_count { get; set; }
        public string in_reply_to_status_id_str { get; set; }
        public int id { get; set; }
        public object geo { get; set; }
        public bool retweeted { get; set; }
        public int? in_reply_to_user_id { get; set; }
        public object place { get; set; }
        public int favorite_count { get; set; }
        public User user { get; set; }
        public string in_reply_to_screen_name { get; set; }
        public string source { get; set; }
        public int? in_reply_to_status_id { get; set; }
    }
}