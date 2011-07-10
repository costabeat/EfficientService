namespace EfficientService.Core.Entities
{
    public class IncidentType : IEntity
    {
        public int ID { get; internal set; }
        public string Type { get; set; }
        public int Complexity { get; set; }
    }
}