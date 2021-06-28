using AutoMapper;
using DAL;
using BL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Configur
{ 
 public static class MapperConfig
{
    public static IMapper Mapper { get; set; }
    static MapperConfig()
    {
        var config = new MapperConfiguration(
            cfg =>
            {                
                cfg.CreateMap<ApplicationUserIdentity, LoginViewModel>().ReverseMap();
                cfg.CreateMap<ApplicationUserIdentity, RegisterViewodel>().ReverseMap();
                cfg.CreateMap<Language, LanguageViewModel>().ReverseMap();
                cfg.CreateMap<Actor, ActorViewModel>().ReverseMap();
                cfg.CreateMap<Comment, CommentViewModel>().ReverseMap();
                cfg.CreateMap<Cast, CastViewModel>().ReverseMap();
                cfg.CreateMap<Certificate, CertificateViewModel>().ReverseMap();
                cfg.CreateMap<Director, DirectorViewModel>().ReverseMap();
                cfg.CreateMap<Film, FilmViewModel>().ReverseMap();
                cfg.CreateMap<Genre, GenreViewModel>().ReverseMap();
                cfg.CreateMap<Country, CountryViewModel>().ReverseMap();
                });
        Mapper = config.CreateMapper();
    }
}
}
