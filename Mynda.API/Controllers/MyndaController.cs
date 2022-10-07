using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mynda.Persistence.Entities;

namespace Mynda.API.Controllers
{
    [ApiController]
    [Route("[controller]/api/vi")]
    public class MyndaController : ControllerBase
    {
        private readonly UserManager<Myndas> _myndaManager;
        private readonly SignInManager<Myndas> _signInManager;
        private readonly Logger<MyndaController> _logger;


        public MyndaController(
            UserManager<Myndas> myndaManager,
            SignInManager<Myndas> signInManager,
            Logger<MyndaController> logger)
        {
            _myndaManager = myndaManager;
            _signInManager = signInManager;
            _logger = logger;
        }


       /* [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost("RegisterMynda")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterMynda([FromBody] Myndas mynda)
        {
            _logger.LogInformation($"Registration attempt for {mynda.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var registeredMynda = await _myndaManager.CreateAsync(mynda, mynda.PasswordHash);
                if (!registeredMynda.Succeeded)
                {
                    return BadRequest($"User Registration Attempt Failed");
                }

                return Accepted();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in the {nameof(RegisterMynda)}");
                return Problem($"Something went wrong in the {nameof(RegisterMynda)}");

            }
            

        }*/

    }
}
