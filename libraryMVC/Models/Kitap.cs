using System.ComponentModel.DataAnnotations;

namespace libraryMVC.Models
{
    public class Kitap
    {
        [Key]
        public int KitapNo { get; set; }

        [Display(Name = "Kitap Adı")]
        public string KitapAd { get; set; }

        [Display(Name = "Kitap Yazarı")]
        public string KitapYazari { get; set; }

        [Display(Name = "Kitap Baskı Yılı")]
        public int KitapBaskiYil { get; set; }

        [Display(Name = "Kitap Sayfa Sayısı")]
        public int KitapSayfaSayi { get; set; }

        [Display(Name = "Kitap Dili")]
        public string KitapDil { get; set; }

        [Display(Name = "Kitap Yayın Evi")]
        public string KitapYayinEvi { get; set; }

        [Display(Name = "Kitap Açıklaması")]
        public string KitapAciklama { get; set; }

    }
}