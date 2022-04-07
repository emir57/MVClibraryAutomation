using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace libraryMVC.Entities
{
    public class Uye : IdentityUser
    {
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string UyeTelefon { get; set; }
        public string UyeAdres { get; set; }

    }
}