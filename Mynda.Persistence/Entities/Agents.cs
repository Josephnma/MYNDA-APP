using Mynda.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class Agents
    {
        public int Id { get; set; }

        [ForeignKey("Users")]
        public string UserId { get; set; }
        public User Users { get; set; }
        
        [ForeignKey("ShareHolderDetails")]
        public int ShareHolder { get; set; }
        public ShareHolder ShareHolderDetails { get; set; }
        
        public string? Sex { get; set; }
        
        
        public string StateOfOrigin { get; set; }
        
        public string BVN { get; set; }
        
        public string NIN { get; set; }
        
        public string UtilityBill { get; set; }
        
        public string Address { get; set; }
        
        public string CompanyName { get; set; }
        
        public string CompanyEmail { get; set; }
        
        public string CompanyPhoneNumber { get; set; }
        
        public string OfficeAddress { get; set; }
        
        public string SelectService { get; set; }
        
        public string? LGA { get; set; }

        public string? Religion { get; set; }

        public string? AboutMe { get; set; }
        
        public string? PhotoUrl { get; set; }

        
    }
    
}
