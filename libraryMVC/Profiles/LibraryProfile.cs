using AutoMapper;
using libraryMVC.Entities;
using libraryMVC.Models;

namespace libraryMVC.Profiles
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {
            CreateMap<Kitap, KitapViewModel>();
            CreateMap<KitapViewModel, Kitap>();

            CreateMap<Emanet, EmanetViewModel>();
            CreateMap<EmanetViewModel, Emanet>();
        }
    }
}