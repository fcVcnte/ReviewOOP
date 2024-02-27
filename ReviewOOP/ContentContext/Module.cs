using ReviewOOP.SharedContext;

namespace ReviewOOP.ContentContext
{
    public class Module : Entity
    {
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public ICollection<Lecture> Lectures { get; set; }
        public Module()
        {
            Lectures = new List<Lecture>();
        }
    }
}
