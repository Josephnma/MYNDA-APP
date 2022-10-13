using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mynda.Persistence.Entities;
using Mynda.Persistence.UnitOfWork;
using Mynda.Shared.DTOs;
using Serilog.Core;

namespace Mynda.API.Controllers
{
    [ApiController]
    [Route("[controller]/api/vi")]
    public class MyndaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly Logger _logger;

        public MyndaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
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


        [HttpGet("{id:int}", Name = "GetMyndasById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
       
        public async Task<IActionResult> GetMyndasById(string id)
        {
            var mynda = await _unitOfWork.Myndas.Get(q => q.Id.Equals(id), new List<string> { "Myndas" });
            var result = _mapper.Map<MyndasDTO>(mynda);
            return Ok(result);
        }

        //[Authorize]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateMynda([FromBody] MyndasDTO myndasDTO)
        {
            if (!ModelState.IsValid)
            {
               // _logger.Error($"Invalid POST attempt in {nameof(CreateMynda)}");
                return BadRequest(ModelState);
            }

            var mynda = _mapper.Map<Myndas>(myndasDTO);
            await _unitOfWork.Myndas.Insert(mynda);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetMyndasById", new {id = mynda.Id}, mynda );
        }

        //[Authorize]
        [HttpPut("{id:int}")] 
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateMynda(string id, [FromBody] MyndasDTO myndasDTO)
        {
            if(!ModelState.IsValid || id.Equals("0"))
            {
                return BadRequest(ModelState);
            } 

            var mynda = await _unitOfWork.Myndas.Get(q => q.Id.Equals(id));
            if(mynda == null)
            {
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(myndasDTO, mynda);
            _unitOfWork.Myndas.Update(mynda);
            await _unitOfWork.Save();

            return NoContent();
        }

        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteMynda(string id)
        {
            if (id.Equals("0"))
            {
                return BadRequest();
            }

            var mynda = await _unitOfWork.Myndas.Get(q => q.Id.Equals(id));
            if (mynda == null)
            {
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Myndas.Delete(id);
            await _unitOfWork.Save();

            return NoContent();
        }


    }
}
