using System.Collections.Generic;

namespace TwitterSupport.Model.Tweet
{
    public class TweetRoot
    {
        public List<TweetJSON> statuses { get; set; }
    }
}