﻿using MagicVilla.Models.Models.DTOs.AuthDTOs;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);

        Task<LoginResponseDTO> Login(LoginRequestDTO dto);

        Task<UserDTO> Register(RegisterationRequestDTO dto);
    }
}
