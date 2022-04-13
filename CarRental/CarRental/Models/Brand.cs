using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }

        [Required(ErrorMessage ="{0} Boş Geçilemez!"),Display(Name ="Marka"),StringLength(20,MinimumLength =3,ErrorMessage ="{0} En {2}-{1} karakter olmalı!")]//marka ekleme sayfasında boş geçilirse müşterinin göreceği cevap
        public string BrandName { get; set; }

    }
}