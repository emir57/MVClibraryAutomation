using System.ComponentModel.DataAnnotations;

namespace libraryMVC.Models
{
    public class Kitap
    {
        [Key]
        public int KitapNo { get; set; }

        [Display(Name = "Kitap Adı")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(30, ErrorMessage = "{0} maksimum 30 karakter olabilir")]
        public string KitapAd { get; set; }

        [Display(Name = "Kitap Yazarı")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(30, ErrorMessage = "{0} maksimum 30 karakter olabilir")]
        public string KitapYazari { get; set; }

        [Display(Name = "Kitap Baskı Yılı")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public int KitapBaskiYil { get; set; }

        [Display(Name = "Kitap Sayfa Sayısı")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public int KitapSayfaSayi { get; set; }

        [Display(Name = "Kitap Dili")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(20, ErrorMessage = "{0} maksimum 20 karakter olabilir")]
        public string KitapDil { get; set; }

        [Display(Name = "Kitap Yayın Evi")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(30, ErrorMessage = "{0} maksimum 30 karakter olabilir")]
        public string KitapYayinEvi { get; set; }

        [Display(Name = "Kitap Açıklaması")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        [MaxLength(250, ErrorMessage = "{0} maksimum 250 karakter olabilir")]
        public string KitapAciklama { get; set; }

    }
}