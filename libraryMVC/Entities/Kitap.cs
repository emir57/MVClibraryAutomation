using System.ComponentModel.DataAnnotations;

namespace libraryMVC.Entities
{
    public class Kitap
    {
        [Key]
        public int KitapNo { get; set; }
        public string KitapAd { get; set; }
        public string KitapYazari { get; set; }
        public int KitapBaskiYil { get; set; }
        public int KitapSayfaSayi { get; set; }
        public string KitapDil { get; set; }
        public string KitapYayinEvi { get; set; }
        public string KitapAciklama { get; set; }
    }
}