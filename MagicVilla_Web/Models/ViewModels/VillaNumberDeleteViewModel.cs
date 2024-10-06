namespace MagicVilla_Web.Models.ViewModels
{
    public class VillaNumberDeleteViewModel
    {
        public VillaNumberDTO VillaNumber { get; set; }

        public VillaNumberDeleteViewModel() => VillaNumber = new VillaNumberDTO();

        [ValidateNever]
        public IEnumerable<SelectListItem> Villas { get; set; }
    }
}
