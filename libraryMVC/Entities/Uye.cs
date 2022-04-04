using System.ComponentModel.DataAnnotations;
namespace libraryMVC.Models
{
    public class Uye
    {
        [Key]
        public int UyeNo { get; set; }

        [Display(Name = "Üye Adı")]
        [Required(ErrorMessage = "{0} zorunlu")]
        [MaxLength(20, ErrorMessage = "{0} maksimum 20 karakter olabilir")]
        [RegularExpression("(?i:^[a-züığçşö][a-züığçşö]*)", ErrorMessage = "Geçersiz üye adı")]
        public string UyeAd { get; set; }

        [Display(Name = "Üye Soyadı")]
        [Required(ErrorMessage = "{0} zorunlu")]
        [MaxLength(20, ErrorMessage = "{0} maksimum {1} karakter olabilir")]
        [RegularExpression("(?i:^[a-züığçşö][a-züığçşö]*)", ErrorMessage = "Geçersiz üye soyadı")]
        public string UyeSoyad { get; set; }

        [Display(Name = "Üye Telefonu")]
        [Required(ErrorMessage = "{0} zorunlu")]
        [MaxLength(14, ErrorMessage = "{0} maksimum {1} karakter olabilir")]
        [RegularExpression(@"^\(\d{3}\)\s\d{3}-\d{4}", ErrorMessage = "Geçersiz üye telefonu (555) 555-5555")]
        public string UyeTelefon { get; set; }

        [Display(Name = "Üye Epostası")]
        [Required(ErrorMessage = "{0} zorunlu")]
        [MaxLength(30, ErrorMessage = "{0} maksimum {1} karakter olabilir")]
        [EmailAddress(ErrorMessage = "Geçersiz üye eposta adresi")]
        public string UyeEposta { get; set; }

        [Display(Name = "Üye Adresi")]
        [Required(ErrorMessage = "{0} zorunlu")]
        [MaxLength(250, ErrorMessage = "{0} maksimum {1} karakter olabilir")]
        public string UyeAdres { get; set; }

    }
}