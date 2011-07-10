namespace EfficientService.Core.Entities
{
    public class Article : IEntity
    {
        public int ID { get; internal set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
