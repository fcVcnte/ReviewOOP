namespace ReviewOOP.ContentContext
{
    public class Career : Content
    {
        public ICollection<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;
        public Career(string title, string url)
            : base(title, url)
        {
            Items = new List<CareerItem>();
        }
    }
}
