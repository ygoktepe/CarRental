using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class FuelType
    {
        [Key]
        public int FuelTypeID { get; set; }
       
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Yakıt Türü"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} En {2}-{1} karakter olmalı!")]
        public string FuelTypeName { get; set; }

    }
}