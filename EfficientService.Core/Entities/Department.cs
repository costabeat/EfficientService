namespace EfficientService.Core.Entities
{
    public class Department : IEntity
    {
        public int ID { get; internal set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Web { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int? ParentID { get; set; }
        public int ServiceID { get; set; }
    }
}
