namespace Balta.ContentContext
{
    public class CarrerItem
    {
        public CarrerItem(int order, string title, string description, Course course)
        {
            this.Order = order;
            this.Title = title;
            this.Description = description;
            this.Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}