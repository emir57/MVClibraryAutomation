using System.ComponentModel.DataAnnotations;
namespace libraryMVC.Models
{
    public class Uye
    {
        [Key]
        public int UyeNo { get; set; }

        [Display(Name = "Üye Adı")]
        [Required(ErrorMessage = " Üye adı zorunlu")]
        [MaxLength(20, ErrorMessage = "Üye adı maksimum 20 karakter olabilir")]
        [RegularExpression("/^[a-z ,.'-]+$/i", ErrorMessage = "Geçersiz üye adı")]
        public string UyeAd { get; set; }

        [Display(Name = "Üye Soyadı")]
        [Required(ErrorMessage = " Üye soyadı zorunlu")]
        [MaxLength(20, ErrorMessage = "Üye soyadı maksimum 20 karakter olabilir")]
        [RegularExpression("/^[a-z ,.'-]+$/i", ErrorMessage = "Geçersiz üye soyadı")]
        public string UyeSoyad { get; set; }

        [Display(Name = "Üye Telefonu")]
        public string UyeTelefon { get; set; }

        [Display(Name = "Üye Epostası")]
        public string UyeEposta { get; set; }

        [Display(Name = "Üye Adresi")]
        public string UyeAdres { get; set; }

    }
}