using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Marka")]

        public byte BrandID { get; set; }

        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Renk")]
        public byte CarColorID { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Araba Modeli"), StringLength(50, MinimumLength = 3, ErrorMessage = "{0} En {2}-{1} karakter olmalı!")]
        public string CarModel { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Yakıt Tipi")]

        public byte FuelTypeID { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Vires Tipi")]

        public byte GearTypeID { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Koltuk Sayısı")]

        public int SeatNumber { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Kasa Tipi")]

        public byte BodyTypeID { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Bagaj Hacmi")]

        public short LuggageVolume { get; set; }

        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Model Yılı")]
        public short ModelYear { get; set; }



        public Brand Brand { get; set; }
        public CarColor CarColor { get; set; }
        public FuelType FuelType { get; set; }
        public GearType GearType { get; set; }
        public BodyType BodyType { get; set; }


    }
}
