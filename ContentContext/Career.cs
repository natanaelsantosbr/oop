using System.Collections;
using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Career : Content
    {


        public Career(string title, string url) : base(title, url)
        {
            this.Items = new List<CarrerItem>();

        }
        public IList<CarrerItem> Items { get; set; }

        //Expression Body
        public int TotalCourses => this.Items.Count;

    }
}