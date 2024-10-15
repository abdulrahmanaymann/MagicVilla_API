using MagicVilla.Models.Models.DTOs.VillaNumberDTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModels
{
    public class VillaNumberCreateViewModel
    {
        public VillaNumberCreateDTO VillaNumber { get; set; }

        public VillaNumberCreateViewModel() => VillaNumber = new VillaNumberCreateDTO();

        [ValidateNever]
        public IEnumerable<SelectListItem> Villas { get; set; }
    }
}
