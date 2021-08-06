using System.ComponentModel.DataAnnotations;
namespace libraryMVC.Models
{
    public class Uye
    {
        [Key]
        public int UyeNo {get; set;}
        public string UyeAd {get; set;}
        public string UyeSoyad {get; set;}
        public string UyeTelefon {get; set;}
        public string UyeEposta {get; set;}
        public string UyeAdres {get; set;}
        
    }
}