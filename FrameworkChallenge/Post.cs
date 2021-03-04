namespace FrameworkChallenge
{
    public class Post : BasePost
    {
        public string Body { get; private set; }

        public Post(int userId, int id, string title, string body)
        {
            UserId = userId;
            Id = id;
            Title = title;
            Body = body;
        }
    }
}
