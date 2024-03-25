
namespace Domain.Entities
{
    public class TaskEntity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public int Priority { get; private set; }
        public List<string> Tags { get; private set; }

        public TaskEntity(string title, string description, int priority, List<string> tags, DateTime expirationDate)
        {
            Title = title;
            Description = description;
            Priority = priority;
            Tags = tags;
            ExpirationDate = expirationDate;
        }
    }
}
