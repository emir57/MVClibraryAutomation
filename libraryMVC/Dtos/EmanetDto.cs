using libraryMVC.Entities;
using libraryMVC.Models;

namespace libraryMVC.Dtos
{
    public class EmanetDto
    {
        public Uye Uye {get; set;}
        public Kitap Kitap {get; set;}
        public EmanetViewModel Emanet { get; set; }
    }
}