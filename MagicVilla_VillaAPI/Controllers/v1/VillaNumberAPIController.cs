using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;

namespace MagicVilla_VillaAPI.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class VillaNumberAPIController(IMapper mapper, IVillaNumberRepository villaNumberRepository, IVillaRepository villaRepository) : ControllerBase
    {
        protected APIResponse _response = new();
        private readonly IMapper _mapper = mapper;
        private readonly IVillaNumberRepository _villaNumberRepository = villaNumberRepository;
        public readonly IVillaRepository _villaRepository = villaRepository;

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetAllVillaNumbers()
        {
            try
            {
                IEnumerable<VillaNumber> villaNumbers = await _villaNumberRepository
                    .GetAllAsync(includeProperties: "Villa");
                _response.Result = _mapper.Map<List<VillaNumberDTO>>(villaNumbers);
                return Ok(_response);
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.ErrorMessages = [ex.Message];
            }

            return _response;
        }


        [HttpGet("{villaNo:int}", Name = "GetVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaNumbers(int villaNo)
        {
            try
            {
                if (villaNo == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var villNumber = await _villaNumberRepository.GetAsync(u => u.VillaNo == villaNo);
                if (villNumber == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<VillaNumberDTO>(villNumber);

                return Ok(_response);
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.ErrorMessages = [ex.Message];
            }

            return _response;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVillaNumber([FromBody] VillaNumberCreateDTO createDTO)
        {
            try
            {
                if (await _villaNumberRepository.GetAsync(u => u.VillaNo == createDTO.VillaNo) != null)
                {
                    ModelState.AddModelError("ErrorMessages", "Villa Number already exists!");
                    return BadRequest(ModelState);
                }

                if (await _villaRepository.GetAsync(u => u.Id == createDTO.VillaId) == null)
                {
                    ModelState.AddModelError("ErrorMessages", "Villa Id is invalid!");
                    return BadRequest(ModelState);
                }

                if (createDTO == null)
                {
                    _response.IsSuccess = false;
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);

                }

                VillaNumber villaNumber = _mapper.Map<VillaNumber>(createDTO);
                await _villaNumberRepository.CreateAsync(villaNumber);

                _response.Result = _mapper.Map<VillaNumberDTO>(villaNumber);
                _response.StatusCode = HttpStatusCode.Created;

                return CreatedAtRoute("GetVillaNumber", new { villaNo = villaNumber.VillaNo }, _response);
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.ErrorMessages = [ex.Message];
            }

            return _response;
        }

        [HttpDelete("{villaNo:int}", Name = "DeleteVillaNumber")]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteVillaNumber(int villaNo)
        {
            try
            {
                if (villaNo == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var villaNumber = await _villaNumberRepository.GetAsync(u => u.VillaNo == villaNo);
                if (villaNumber == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                await _villaNumberRepository.RemoveAsync(villaNumber);

                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.ErrorMessages = [ex.Message];
            }

            return _response;
        }

        [HttpPut("{villaNo:int}", Name = "UpdateVillaNumber")]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateVillaNumber(int villaNo, [FromBody] VillaNumberUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || villaNo != updateDTO.VillaNo)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                if (await _villaRepository.GetAsync(u => u.Id == updateDTO.VillaId) == null)
                {
                    ModelState.AddModelError("ErrorMessages", "Villa Id is invalid!");
                    return BadRequest(ModelState);
                }

                VillaNumber villaNumber = _mapper.Map<VillaNumber>(updateDTO);

                await _villaNumberRepository.UpdateAsync(villaNumber);

                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.ErrorMessages = [ex.Message];
            }

            return _response;
        }
    }
}
