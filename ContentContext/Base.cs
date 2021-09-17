using System;
using Balta.NotificationContext;

namespace Balta.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            this.Id = Guid.NewGuid(); //SPOF - Menos pontos de falha
        }
        public Guid Id { get; set; }
    }
}