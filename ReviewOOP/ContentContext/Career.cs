using ReviewOOP.SharedContext;

namespace ReviewOOP.ContentContext
{
    public class Career : Entity
    {
        public ICollection<Course> Courses { get; set; }
    }
}
