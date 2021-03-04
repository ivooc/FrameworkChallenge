namespace FrameworkChallenge
{
    public abstract class BasePost
    {
        public int UserId { get; protected set; }
        public int Id { get; protected set; }
        public string Title { get; protected set; }
    }
}
