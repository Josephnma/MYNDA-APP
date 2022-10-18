using Agents.Shared.DTOs;
using AutoMapper;
using Mynda.Persistence.Entities;
using Mynda.Shared.DTOs;

namespace Mynda.Domain.Mappings
{
    public class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Myndas, MyndasDTO>().ReverseMap();
            CreateMap<Persistence.Entities.Agents, AgentsDTO>().ReverseMap();
        }
    }
}
