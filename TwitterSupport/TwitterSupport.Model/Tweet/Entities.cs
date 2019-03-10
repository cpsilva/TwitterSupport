namespace TwitterSupport.Model.Tweet
{
    public class Entities
    {
        public Urls[] urls { get; set; }
        public object[] hashtags { get; set; }
        public UserMentions[] user_mentions { get; set; }
    }
}