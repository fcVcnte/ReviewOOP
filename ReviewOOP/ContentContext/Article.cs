using ReviewOOP.SharedContext;

namespace ReviewOOP.ContentContext
{
    public class Article : Entity
    {
        public Article(string title, string url)
            : base(title, url)
        {
        }
    }
}
