namespace ReviewOOP.SharedContext
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;

        public Entity(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }
    }
}
