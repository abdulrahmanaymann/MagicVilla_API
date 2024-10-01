namespace MagicVilla_Web.Models.Dto
{
    public class VillaNumberDTO
    {
        public int VillaNo { get; set; }

        public string SpecialDetails { get; set; } = string.Empty;

        [Required]
        public int VillaId { get; set; }
    }
}
