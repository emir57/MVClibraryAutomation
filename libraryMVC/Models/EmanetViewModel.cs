using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using libraryMVC.Entities;

namespace libraryMVC.Models
{
    public class EmanetViewModel
    {
        public List<Uye> Uyeler { get; set; }
        public List<Kitap> Kitaplar { get; set; }
        
        public int EmanetNo { get; set; }

        [Display(Name = "Üye")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string UyeId { get; set; }

        [Display(Name = "Kitap")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public int KitapNo { get; set; }

        [Display(Name = "Emanet Verme Tarihi")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string EmanetVermeTarih { get; set; }

        [Display(Name = "Emanet Geri Alma Tarihi")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string EmanetGeriAlmaTarih { get; set; }

        [Display(Name = "Emanet İşlem Tarihi")]
        public string EmanetIslemTarih { get; set; }
        [Display(Name = "Emanet Not")]
        public string EmanetNot { get; set; }

        [Display(Name = "Emanet Teslim Durumu")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string EmanetTeslimEdildi { get; set; }
    }
}