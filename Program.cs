using System;
using System.Collections.Generic;
using Balta.ContentContext;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "chsarp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            foreach (var article in articles)
            {
                System.Console.WriteLine(article.Id);
                System.Console.WriteLine(article.Title);
                System.Console.WriteLine(article.Url);
            }

        }
    }
}