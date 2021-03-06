using System.ComponentModel.DataAnnotations;

namespace libraryMVC.Models
{
    public class KitapViewModel
    {
        public int KitapNo { get; set; }
        [Display(Name = "Kitap Adı")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(30, ErrorMessage = "{0} maksimum {1} karakter olabilir")]
        public string KitapAd { get; set; }

        [Display(Name = "Kitap Yazarı")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(30, ErrorMessage = "{0} maksimum {1} karakter olabilir")]
        public string KitapYazari { get; set; }

        [Display(Name = "Kitap Baskı Yılı")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public int KitapBaskiYil { get; set; }

        [Display(Name = "Kitap Sayfa Sayısı")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public int KitapSayfaSayi { get; set; }

        [Display(Name = "Kitap Dili")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(20, ErrorMessage = "{0} maksimum {1} karakter olabilir")]
        public string KitapDil { get; set; }

        [Display(Name = "Kitap Yayın Evi")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(30, ErrorMessage = "{0} maksimum {1} karakter olabilir")]
        public string KitapYayinEvi { get; set; }

        [Display(Name = "Kitap Açıklaması")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(250, ErrorMessage = "{0} maksimum {1} karakter olabilir")]
        public string KitapAciklama { get; set; }
        [Display(Name = "Kitap Kiralık")]
        public bool IsActive { get; set; }
    }
}