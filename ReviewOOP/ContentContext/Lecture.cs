using ReviewOOP.SharedContext;

namespace ReviewOOP.ContentContext
{
    public class Lecture : Entity
    {
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public int DurationInMinutes { get; set; }
    }
}
