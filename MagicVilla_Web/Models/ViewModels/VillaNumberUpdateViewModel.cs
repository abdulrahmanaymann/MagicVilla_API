using MagicVilla.Models.Models.DTOs.VillaNumberDTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModels
{
    public class VillaNumberUpdateViewModel
    {
        public VillaNumberUpdateDTO VillaNumber { get; set; }

        public VillaNumberUpdateViewModel() => VillaNumber = new VillaNumberUpdateDTO();

        [ValidateNever]
        public IEnumerable<SelectListItem> Villas { get; set; }
    }
}
