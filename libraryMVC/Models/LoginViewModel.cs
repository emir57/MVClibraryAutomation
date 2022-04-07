using System.ComponentModel.DataAnnotations;

namespace libraryMVC.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Eposta")]
        [Required(ErrorMessage = "Eposta boş olamaz")]
        public string EPosta { get; set; }

        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Şifre boş olamaz")]
        public string Sifre { get; set; }

        public bool RememberMe { get; set; }
    }
}