using ReviewOOP.SharedContext;

namespace ReviewOOP.ContentContext
{
    public class Course : Entity
    {
        public string Tag { get; set; } = string.Empty;
        public ICollection<Module> Modules { get; set; }

        public Course()
        {
            Modules = new List<Module>();
        }
    }

    public class Module
    {
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public ICollection<Lecture> Lectures { get; set; }
        public Module()
        {
            Lectures = new List<Lecture>();
        }
    }

    public class Lecture
    {
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
    }
}
