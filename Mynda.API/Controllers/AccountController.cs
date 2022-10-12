using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mynda.API.CustomMiddleware;
using Mynda.Persistence.Entities;
using Mynda.Shared.DTOs;

namespace Mynda.API.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;


        public AccountController(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ILogger<AccountController> logger,
            IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost]
        [Route("register")]
        
        public async Task<IActionResult> RegisterUser([FromBody] UserDTO userDTO)
        {
            _logger.LogInformation($"Registration attempt for {userDTO.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var user = _mapper.Map<User>(userDTO);
                user.UserName = userDTO.Email;
                var result = await _userManager.CreateAsync(user);
                
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest($"User Registration Attempt Failed");
                }

                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in the {nameof(RegisterUser)}");
                return Problem($"Something went wrong in the {nameof(RegisterUser)}", statusCode: 500);
            }

        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost]
        [Route("login")]
     
        public async Task<IActionResult> LoginUser([FromBody] LoginUserDTO userDTO)
        {
            _logger.LogInformation($"Login attempt for {userDTO.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _signInManager.PasswordSignInAsync(userDTO.Email, userDTO.Password, false, false);

                if (!result.Succeeded)
                {
                    return Unauthorized(userDTO);
                }

                return Accepted();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in the {nameof(LoginUser)}");
                return Problem($"Something went wrong in the {nameof(LoginUser)}", statusCode: 500);

            }

        }
    }
}
