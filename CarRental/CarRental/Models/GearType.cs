using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class GearType
    {
        [Key]
        public int GearTypeID { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Vites Tipi"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} En {2}-{1} karakter olmalı!")]
        public string GearTypeName { get; set; }
    }
}