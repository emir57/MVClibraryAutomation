using System.ComponentModel.DataAnnotations;
namespace libraryMVC.Entities
{
    public class Emanet
    {
        [Key]
        public int EmanetNo { get; set; }
        public int UyeNo { get; set; }
        public int KitapNo { get; set; }
        public string EmanetVermeTarih { get; set; }
        public string EmanetGeriAlmaTarih { get; set; }
        public string EmanetIslemTarih { get; set; }
        public string EmanetNot { get; set; }
        public string EmanetTeslimEdildi { get; set; }
    }
}