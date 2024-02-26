using ReviewOOP.SharedContext;

namespace ReviewOOP.ContentContext
{
    public class Career : Entity
    {
        public ICollection<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;
        public Career()
        {
            Items = new List<CareerItem>();
        }
    }
}
