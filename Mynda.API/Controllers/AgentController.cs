using Agents.Shared.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mynda.Persistence.UnitOfWork;
using Serilog.Core;

namespace Mynda.API.Controllers{
    [ApiController]
    [Route("[controller]/api/vi")]
    public class AgentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly Logger _logger;

        public AgentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAgents()
        {
            var agents = await _unitOfWork.Agents.GetAll();
            var result = _mapper.Map<IList<AgentsDTO>>(agents);
            return Ok(result);
        }


        [HttpGet("{id:int}", Name = "GetAgentsById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
       
        public async Task<IActionResult> GetAgentsById(string id)
        {
            var agent = await _unitOfWork.Agents.Get(q => q.Id.Equals(id), new List<string> { "Agents" });
            var result = _mapper.Map<AgentsDTO>(agent);
            return Ok(result);
        }

        //[Authorize]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateAgent([FromBody] AgentsDTO agentDTO)
        {
            if (!ModelState.IsValid)
            {
               // _logger.Error($"Invalid POST attempt in {nameof(CreateMynda)}");
                return BadRequest(ModelState);
            }

            var agent = _mapper.Map<Persistence.Entities.Agents>(agentDTO);
            await _unitOfWork.Agents.Insert(agent);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetAgentsById", new {id = agent.Id}, agent );
        }

        //[Authorize]
        [HttpPut("{id:int}")] 
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateAgent(string id, [FromBody] AgentsDTO agentsDTO)
        {
            if(!ModelState.IsValid || id.Equals("0"))
            {
                return BadRequest(ModelState);
            } 

            var agent = await _unitOfWork.Agents.Get(q => q.Id.Equals(id));
            if(agent == null)
            {
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(agentsDTO, agent);
            _unitOfWork.Agents.Update(agent);
            await _unitOfWork.Save();

            return NoContent();
        }

        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteAgent(string id)
        {
            if (id.Equals("0"))
            {
                return BadRequest();
            }

            var agent = await _unitOfWork.Agents.Get(q => q.Id.Equals(id));
            if (agent == null)
            {
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Agents.Delete(id);
            await _unitOfWork.Save();

            return NoContent();
        }
        
        //Create Agent ShareHolder
        // [HttpPost]
        // [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // [ProducesResponseType(StatusCodes.Status201Created)]
        // [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // public async Task<IActionResult> CreateAgentShareHolder([FromBody] AgentsDTO agentDTO)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         // _logger.Error($"Invalid POST attempt in {nameof(CreateMynda)}");
        //         return BadRequest(ModelState);
        //     }
        //
        //     var agent = _mapper.Map<Persistence.Entities.Agents>(agentDTO);
        //     await _unitOfWork.Agents.Insert(agent);
        //     await _unitOfWork.Save();
        //
        //     return CreatedAtRoute("GetAgentsById", new {id = agent.Id}, agent );
        // }
        //
        //
    }
}

