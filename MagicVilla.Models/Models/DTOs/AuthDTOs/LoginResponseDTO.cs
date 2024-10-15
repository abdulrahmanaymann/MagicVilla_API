namespace MagicVilla.Models.Models.DTOs.AuthDTOs
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }

        public string Token { get; set; }
    }
}
