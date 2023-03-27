namespace DataLayer.Entities
{
    public class Community
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ModeratorId { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}