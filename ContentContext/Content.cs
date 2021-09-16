using System;

namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content(string title, string url)
        {
            this.Id = Guid.NewGuid(); //SPOF - Menos pontos de falha
            this.Title = title;
            this.Url = url;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

    }
}