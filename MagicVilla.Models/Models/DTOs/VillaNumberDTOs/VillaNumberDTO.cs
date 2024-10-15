using System.ComponentModel.DataAnnotations;
using MagicVilla.Models.Models.DTOs.VillaDTOs;

namespace MagicVilla.Models.Models.DTOs.VillaNumberDTOs
{
    public class VillaNumberDTO
    {
        public int VillaNo { get; set; }

        public string SpecialDetails { get; set; } = string.Empty;

        [Required]
        public int VillaId { get; set; }

        public VillaDTO Villa { get; set; } = default!;
    }
}
