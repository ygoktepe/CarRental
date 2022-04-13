using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class deneme
    {
        [Key]
        public int denemeID { get; set; }
        public string denemeName { get; set; }

    }
}
