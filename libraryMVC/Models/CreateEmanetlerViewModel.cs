using System.Collections.Generic;
using libraryMVC.Entities;

namespace libraryMVC.Models
{
    public class EmanetlerViewModel
    {
        public List<Uye> Uyeler { get; set; }
        public List<Kitap> Kitaplar { get; set; }
        public Emanet Emanet { get; set; }
    }
}