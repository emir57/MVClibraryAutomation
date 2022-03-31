using System.ComponentModel.DataAnnotations;
namespace libraryMVC.Models
{
    public class Emanet
    {
        [Key]
        public int EmanetNo { get; set; }


        [Display(Name = "Üye")]
        [Required(ErrorMessage = "UyeNo boş olamaz")]
        public int UyeNo { get; set; }


        [Display(Name = "Kitap")]
        [Required(ErrorMessage = "KitapNo boş olamaz")]
        public int KitapNo { get; set; }


        [Required(ErrorMessage = "Emanet verme tarihi boş olamaz")]
        [Display(Name = "Emanet Verme Tarihi")]
        public string EmanetVermeTarih { get; set; }


        [Required(ErrorMessage = "Emanet geri alma tarihi boş olamaz")]
        [Display(Name = "Emanet Geri Alma Tarihi")]
        public string EmanetGeriAlmaTarih { get; set; }

        [Display(Name = "Emanet İşlem Tarihi")]
        public string EmanetIslemTarih { get; set; }
        [Display(Name = "Emanet Not")]
        public string EmanetNot { get; set; }


        [Required(ErrorMessage = "Emanet teslim edildi boş olamaz")]
        [Display(Name = "Emanet Teslim Durumu")]
        public string EmanetTeslimEdildi { get; set; }
    }
}