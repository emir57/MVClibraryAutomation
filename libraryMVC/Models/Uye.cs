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
        [Required(ErrorMessage = " Üye telefonu zorunlu")]
        [MaxLength(14, ErrorMessage = "Üye telefonu maksimum 14 karakter olabilir")]
        [MinLength(14, ErrorMessage = "Üye telefonu minimum 14 karakter olabilir")]
        [RegularExpression(@"^\(\d{3}\)\s\d{3}-\d{4}", ErrorMessage = "Geçersiz üye telefonu (555) 555-5555")]
        public string UyeTelefon { get; set; }

        [Display(Name = "Üye Epostası")]
        [Required(ErrorMessage = " Üye epostası zorunlu")]
        [MaxLength(30, ErrorMessage = "Üye epostası maksimum 30 karakter olabilir")]
        [EmailAddress(ErrorMessage = "Geçersiz üye eposta adresi")]
        public string UyeEposta { get; set; }

        [Display(Name = "Üye Adresi")]
        public string UyeAdres { get; set; }

    }
}