using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url) : base(title, url)
        {
            this.Modules = new List<Module>();
        }
        public string Tag { get; set; }

        /*Sempre depende da abstração e nunca da implementação . Ex( List)*/
        public IList<Module> Modules { get; set; }
    }



    //Aula

}