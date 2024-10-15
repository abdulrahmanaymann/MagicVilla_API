using System.ComponentModel.DataAnnotations;

namespace MagicVilla.Models.Models.DTOs.VillaNumberDTOs
{
    public class VillaNumberCreateDTO
    {
        public int VillaNo { get; set; }

        public string SpecialDetails { get; set; } = string.Empty;

        [Required]
        public int VillaId { get; set; }
    }
}
