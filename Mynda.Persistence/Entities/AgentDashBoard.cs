using System.ComponentModel.DataAnnotations.Schema;

namespace Mynda.Persistence.Entities
{
    public class AgentDashBoard
    {
        public int Id { get; set; }

        [ForeignKey("Users")]
        public string UserId { get; set; }
        public User Users { get; set; }

        [ForeignKey("AgentKYC")]
        public int AgentKYC { get; set; }
        public AgentKYC AgentsKYC { get; set; }
        
        [ForeignKey("AgentDashBoardFooter")]
        public int AgentDashBoardFooter{ get; set; }
        public AgentDashBoardFooter AgentDashBoard_Footer { get; set; }
        
        [ForeignKey("AgentWallet")]
        public int AgentWallet { get; set; }
        public AgentWallet AgentsWallet { get; set; }
        
        
    }
}
