using BL.Interfaces;
using BL.Repositories;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BL.Bases
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext unitOfWorkContext { get; set; }
        public UnitOfWork()
        {
            unitOfWorkContext = new ApplicationDBContext();
            unitOfWorkContext.Configuration.LazyLoadingEnabled = false;
        }


        public AccountRepository account;
        public AccountRepository Account
        {
            get
            {
                if (account == null)
                    account = new AccountRepository(unitOfWorkContext);
                return account;
            }
        }

        public ActorRepository actor;
        public ActorRepository Actor
        {
            get
            {
                if (actor == null)
                    actor = new ActorRepository(unitOfWorkContext);
                return actor;
            }
        }

        public RoleRepository role;
        public RoleRepository Role
        {
            get
            {
                if (role == null)
                    role = new RoleRepository(unitOfWorkContext);
                return role;
            }
        }

        public CastRepository cast;
        public CastRepository Cast
        {
            get
            {
                if (cast == null)
                    cast = new CastRepository(unitOfWorkContext);
                return cast;
            }
        }
        public CertificateRepository certificate;
        public CertificateRepository Certificate
        {
            get
            {
                if (certificate == null)
                    certificate = new CertificateRepository(unitOfWorkContext);
                return certificate;
            }
        }

        public CommentRepository comment;
        public CommentRepository Comment
        {
            get
            {
                if (comment == null)
                    comment = new CommentRepository(unitOfWorkContext);
                return comment;
            }
        }

        public CountryRepository country;
        public CountryRepository Country
        {
            get
            {
                if (country == null)
                    country = new CountryRepository(unitOfWorkContext);
                return country;
            }
        }

        public DirectorRepository director; 
        public DirectorRepository Director
        {
            get
            {
                if (director == null)
                    director = new DirectorRepository(unitOfWorkContext);
                return director;
            }
        }

        public FilmRepository film;
        public FilmRepository Film
        {
            get
            {
                if (film == null)
                    film = new FilmRepository(unitOfWorkContext);
                return film;
            }
        }

        public GenreRepository genre;
        public GenreRepository Genre
        {
            get
            {
                if(genre==null)
                    genre = new GenreRepository(unitOfWorkContext);
                return genre;
            }
        }

        public LanguageRepository language;

        public LanguageRepository Language
        {
            get
            {
                language = new LanguageRepository(unitOfWorkContext);
                return language;
            }
        }
        public int Commit()
        {
            return unitOfWorkContext.SaveChanges();
        }

        public void Dispose()
        {
            unitOfWorkContext.Dispose();

        }
    }
}
