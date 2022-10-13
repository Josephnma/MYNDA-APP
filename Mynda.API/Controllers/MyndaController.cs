using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mynda.Persistence.Entities;
using Mynda.Persistence.UnitOfWork;
using Mynda.Shared.DTOs;

namespace Mynda.API.Controllers
{
    [ApiController]
    [Route("[controller]/api/vi")]
    public class MyndaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Logger<MyndaController> _logger;
        private readonly IMapper _mapper;

        public MyndaController(IUnitOfWork unitOfWork, Logger<MyndaController> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMyndas()
        {
            var myndas = await _unitOfWork.Myndas.GetAll();
            var result = _mapper.Map<IList<MyndasDTO>>(myndas);
            return Ok(result);
        }


        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        public async Task<IActionResult> GetMyndasById(int id)
        {
            var mynda = await _unitOfWork.Myndas.Get(q => q.Id == id, new List<string> { "Myndas" });
            var result = _mapper.Map<MyndasDTO>(mynda);
            return Ok(result);
        }




    }
}
