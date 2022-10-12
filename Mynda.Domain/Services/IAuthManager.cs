using Mynda.Persistence.Entities;
using Mynda.Shared.DTOs;

namespace Mynda.Domain.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO userDTO);
        Task<string> CreateToken();
    }
}
