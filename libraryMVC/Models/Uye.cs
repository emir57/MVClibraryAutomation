using System.ComponentModel.DataAnnotations;
namespace libraryMVC.Models
{
    public class Uye
    {
        [Key]
        public int UyeNo { get; set; }

        [Display(Name = "Üye Adı")]
        public string UyeAd { get; set; }

        [Display(Name = "Üye Soyadı")]
        public string UyeSoyad { get; set; }

        [Display(Name = "Üye Telefonu")]
        public string UyeTelefon { get; set; }

        [Display(Name = "Üye Epostası")]
        public string UyeEposta { get; set; }

        [Display(Name = "Üye Adresi")]
        public string UyeAdres { get; set; }

    }
}