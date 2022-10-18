using System.ComponentModel.DataAnnotations.Schema;

namespace Mynda.Persistence.Entities
{
    public class AgentDashBoardFooter
    {
        public int Id { get; set; }
        
        [ForeignKey("AgentJob")]
        public int AgentJob { get; set; }
        public AgentJob AgentsJob { get; set; }
        
        [ForeignKey("AgentSavedJobsFooter")]
        public int AgentSavedJobsFooter{ get; set; }
        public AgentSavedJobsFooter AgentSavedJobs { get; set; }
        
        [ForeignKey("AgentWallet")]
        public int AgentsWallet{ get; set; }
        public AgentWallet AgentWallet { get; set; }
    }
}
