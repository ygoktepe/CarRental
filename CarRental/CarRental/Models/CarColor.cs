using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class CarColor
    {
        public int CarColorID { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Renk"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} En {2}-{1} karakter olmalı!")]
        public string CarColorName { get; set; }
    }
}