using libraryMVC.Entities;
using libraryMVC.Models;

namespace libraryMVC.Dtos
{
    public class EmanetDto
    {
        //TODO: Emanet emanet
        public int EmanetNo {get; set;}
        public Uye Uye {get; set;}
        public Kitap Kitap {get; set;}
        public string EmanetVermeTarih {get; set;}
        public string EmanetGeriAlmaTarih {get; set;}
        public string EmanetIslemTarih {get; set;}
        public string EmanetNot {get; set;}
        public string EmanetTeslimEdildi {get; set;}
    }
}