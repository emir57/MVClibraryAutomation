using System.ComponentModel.DataAnnotations;

namespace libraryMVC.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string UyeAd { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string UyeSoyad { get; set; }
        [Display(Name = "Eposta")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string Email { get; set; }
        [Display(Name = "Adres")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string UyeAdres { get; set; }

        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string Sifre { get; set; }

        [Display(Name = "Sifre Tekrar")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [Compare("Sifre",ErrorMessage = "Şifre eşleşmiyor")]
        public string SifreTekrar { get; set; }
    }
}