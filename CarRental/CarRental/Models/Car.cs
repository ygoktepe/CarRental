using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), Display(Name = "Marka")]

        public byte BrandID { get; set; }
        public byte CarColorID { get; set; }
        public string CarModel { get; set; }
        public byte FuelTypeID { get; set; }
        public byte GearTypeID { get; set; }
        public int SeatNumber { get; set; }
        public byte BodyTypeID { get; set; }
        public int  LuggageVolume { get; set; }
        public int ModelYear { get; set; }


        public Brand Brand { get; set; }

        public CarColor CarColor { get; set; }
        public FuelType FuelType { get; set; }
        public GearType GearType { get; set; }
        public BodyType BodyType { get; set; }


    }
}
