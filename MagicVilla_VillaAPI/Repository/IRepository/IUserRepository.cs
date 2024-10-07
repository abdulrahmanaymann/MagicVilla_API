namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);

        Task<LoginResponseDTO> Login(LoginRequestDTO dto);

        Task<LocalUser> Register(RegisterationRequestDTO dto);
    }
}
