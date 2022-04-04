using System.Collections.Generic;
using libraryMVC.Entities;

namespace libraryMVC.Models
{
    public class EmanetViewModel
    {
        public List<Uye> Uyeler { get; set; }
        public List<Kitap> Kitaplar { get; set; }
        public Emanet Emanet { get; set; }
    }
}