using ReviewOOP.SharedContext;

namespace ReviewOOP.ContentContext
{
    public abstract class Content : Entity
    {
        
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;

        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}
