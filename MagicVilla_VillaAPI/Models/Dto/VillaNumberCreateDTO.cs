namespace MagicVilla_VillaAPI.Models.Dto
{
    public class VillaNumberCreateDTO
    {
        public int VillaNo { get; set; }

        public string SpecialDetails { get; set; } = string.Empty;

        [Required]
        public int VillaId { get; set; }
    }
}
