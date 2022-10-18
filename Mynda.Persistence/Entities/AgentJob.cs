namespace Mynda.Persistence.Entities
{
    public class AgentJob
    {
        public int Id { get; set; }
        
        public List<string>? Location { get; set; }
        
        public List<string>? Today { get; set; }
        
        public List<string>? Type { get; set; }
    }
}
