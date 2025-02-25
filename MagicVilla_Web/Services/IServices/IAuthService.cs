using MagicVilla.Models.Models.DTOs.AuthDTOs;

namespace MagicVilla_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO dto);
        Task<T> RegisterAsync<T>(RegisterationRequestDTO dto);
    }
}