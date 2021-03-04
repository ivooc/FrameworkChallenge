using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkChallenge
{
    public class Todo
    {
        public int UserId { get; private set; }
        public int Id { get; private set; }
        public string Title { get; private set; }
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
