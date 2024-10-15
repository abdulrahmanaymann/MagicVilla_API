using Asp.Versioning;
using AutoMapper;
using MagicVilla.Models.Models.APIResponse;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers.v2
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIvController(IMapper mapper, IVillaNumberRepository villaNumberRepository, IVillaRepository villaRepository) : ControllerBase
    {
        protected APIResponse _response = new();
        private readonly IMapper _mapper = mapper;
        private readonly IVillaNumberRepository _villaNumberRepository = villaNumberRepository;
        public readonly IVillaRepository _villaRepository = villaRepository;

        [HttpGet("GetString")]
        [MapToApiVersion("2.0")]
        public IEnumerable<string> Get()
        {
            return ["value1", "value2"];
        }
    }
}
