namespace FrameworkChallenge.Models
{
    public class Todo : BasePost
    {
        public bool Completed { get; private set; }

        public Todo(int userId, int id, string title, bool completed)
        {
            UserId = userId;
            Id = id;
            Title = title;
            Completed = completed;
        }
    }
}
