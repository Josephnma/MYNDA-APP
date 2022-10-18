using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mynda.Persistence.Entities;
using Mynda.Persistence.UnitOfWork;
using Mynda.Shared.DTOs;
using Serilog.Core;

namespace Mynda.API.Controllers
{
    [ApiController]
    [Route("[controller]/api/vi")]
    public class AgentDashBoardController : ControllerBase
    {
        
        
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly Logger _logger;

            public AgentDashBoardController(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            [HttpGet]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public async Task<IActionResult> GetAgentDashBoard()
            {
                var agent_dashboard = await _unitOfWork.AgentDashBoard.GetAll();
                var result = _mapper.Map<IList<AgentDashBoard>>(agent_dashboard);
                return Ok(result);
            }
    }
}
