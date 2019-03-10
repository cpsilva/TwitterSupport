namespace TwitterSupport.Model.Tweet
{
    public class UserMentions
    {
        public string screen_name { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string id_str { get; set; }
        public int[] indices { get; set; }
    }
}