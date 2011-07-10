namespace EfficientService.Core.Entities
{
    public class Category : IEntity
    {
        public int ID { get; internal set; }
        public string Title { get; set; }
    }
}
