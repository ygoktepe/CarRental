using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class BodyType
    {
        [Key]
        public int BodyTypeID { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Kasa Tipi"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} En {2}-{1} karakter olmalı!")]
        public string BodyTypeName { get; set; }
    }
}