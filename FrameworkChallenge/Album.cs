namespace FrameworkChallenge
{
    public class Album : BasePost
    {
        public Album(int userId, int id, string title)
        {
            UserId = userId;
            Id = id;
            Title = title;
        }
    }
}
