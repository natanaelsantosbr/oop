using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            this.Modules = new List<Module>();
        }
        public string Tag { get; set; }

        /*Sempre depende da abstração e nunca da implementação . Ex( List)*/
        public IList<Module> Modules { get; set; }
    }

    public class Module
    {
        public Module()
        {
            this.Lectures = new List<Lecture>();
        }

        public int Order { get; set; }

        public string Title { get; set; }

        public IList<Lecture> Lectures { get; set; }
    }

    //Aula
    public class Lecture
    {
        public int Order { get; set; }

        public string Title { get; set; }
    }
}