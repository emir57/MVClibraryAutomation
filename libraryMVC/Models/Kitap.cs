using System.ComponentModel.DataAnnotations;

namespace libraryMVC.Models
{
    public class Kitap
    {
        [Key]
        public int KitapNo { get; set; }

        [Display(Name = "Kitap Adı")]
        [Required(ErrorMessage = "Kitap adı boş olamaz")]
        public string KitapAd { get; set; }

        [Display(Name = "Kitap Yazarı")]
        [Required(ErrorMessage = "Kitap yazarı boş olamaz")]
        public string KitapYazari { get; set; }

        [Display(Name = "Kitap Baskı Yılı")]
        [Required(ErrorMessage = "Kitap baskı yılı boş olamaz")]
        public int KitapBaskiYil { get; set; }

        [Display(Name = "Kitap Sayfa Sayısı")]
        [Required(ErrorMessage = "Kitap sayfa sayısı boş olamaz")]
        public int KitapSayfaSayi { get; set; }

        [Display(Name = "Kitap Dili")]
        [Required(ErrorMessage = "Kitap dili boş olamaz")]
        public string KitapDil { get; set; }

        [Display(Name = "Kitap Yayın Evi")]
        [Required(ErrorMessage = "Kitap yayın evi boş olamaz")]
        public string KitapYayinEvi { get; set; }

        [Display(Name = "Kitap Açıklaması")]
        [Required(ErrorMessage = "Kitap açıklaması boş olamaz")]
        public string KitapAciklama { get; set; }

    }
}