using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Mynda.Domain.Services
{
    public class AuthManager
    {
        private readonly IConfiguration _config;
        private readonly UserManager<Persistence.Entities.Myndas> _myndaManager;

    }
}
