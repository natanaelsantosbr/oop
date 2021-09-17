using System;
using System.Collections.Generic;
using System.Linq;
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

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-chsarp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();

            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CarrerItem(2, "OOP", "", courseOOP);
            var careerItem2 = new CarrerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CarrerItem(3, "C#", "", courseAspNet);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);



            foreach (var career in careers)
            {
                System.Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order).ToList())
                {
                    System.Console.WriteLine($"{item.Order} - {item.Title}");
                    System.Console.WriteLine($"{item.Course.Title}");
                }
            }


        }
    }
}