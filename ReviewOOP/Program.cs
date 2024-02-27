using ReviewOOP.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("OOP article", "object-oriented-programming"));
articles.Add(new Article("C# article", "csharp-language"));
articles.Add(new Article(".NET article", "dotnet-framework"));

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}