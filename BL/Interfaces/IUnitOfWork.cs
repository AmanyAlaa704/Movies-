using BL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        //instant of Reporsitories
        AccountRepository Account { get; }
        ActorRepository Actor { get; }
        RoleRepository Role { get; }
        CastRepository Cast { get; }
        CertificateRepository Certificate { get; }
        CommentRepository Comment { get; }
        CountryRepository Country { get; }
        DirectorRepository Director { get; }
        FilmRepository Film { get; }
        GenreRepository Genre { get; }
        LanguageRepository Language { get; }
    }  
}
