namespace MagicVilla_Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly IMapper _mapper;

        private readonly IVillaNumberService _villaNumberService;

        public VillaNumberController(IMapper mapper, IVillaNumberService villaNumberService)
        {
            _mapper = mapper;
            _villaNumberService = villaNumberService;
        }

        public async Task<IActionResult> Index()
        {
            List<VillaNumberDTO> villaNumbers = new();

            var response = await _villaNumberService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                villaNumbers = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(response.Result));
            }

            return View(villaNumbers);
        }
    }
}
