using System.ComponentModel.DataAnnotations;
namespace libraryMVC.Models
{
    public class Emanet
    {
        [Key]
        public int EmanetNo {get; set;}
        [Required(ErrorMessage = "UyeNo boş olamaz")]
        public int UyeNo {get; set;}
        [Required(ErrorMessage = "KitapNo boş olamaz")]
        public int KitapNo {get; set;}
        [Required(ErrorMessage = "Emanet verme tarihi boş olamaz")]
        public string EmanetVermeTarih {get; set;}
        [Required(ErrorMessage = "Emanet geri alma tarihi boş olamaz")]
        public string EmanetGeriAlmaTarih {get; set;}
        public string EmanetIslemTarih {get; set;}
        public string EmanetNot {get; set;}
        [Required(ErrorMessage = "Emanet teslim edildi boş olamaz")]
        public string EmanetTeslimEdildi {get; set;}
    }
}