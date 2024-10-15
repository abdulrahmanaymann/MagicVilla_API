using MagicVilla.Models.Models.DTOs.VillaNumberDTOs;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>(string token);

        Task<T> GetAsync<T>(int VillaNo, string token);

        Task<T> CreateAsync<T>(VillaNumberCreateDTO dto, string token);

        Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto, string token);

        Task<T> DeleteAsync<T>(int villaNo, string token);
    }
}
