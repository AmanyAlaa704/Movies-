using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Bases;
using DAL;
using BL.ViewModel;

namespace BL.AppServices
{
   public class FilmAppService : AppServiceBase
    {

        public List<FilmViewModel> GetAllFilms()
        {

            return Mapper.Map<List<FilmViewModel>>(TheUnitOfWork.Film.GetAllFilm());
        }
        public FilmViewModel GetFilm(int id)
        {
            return Mapper.Map<FilmViewModel>(TheUnitOfWork.Film.GetFilmById(id));
        }

        public bool SaveNewFilm(FilmViewModel filmViewModel)
        {
            bool result = false;
            var film = Mapper.Map<Film>(filmViewModel);
            if (TheUnitOfWork.Film.Insert(film))
            {
                result = TheUnitOfWork.Commit() > new int();
            }
            return result;
        }

        public bool UpdateFilm(FilmViewModel filmViewModel)
        {
            var film = Mapper.Map<Film>(filmViewModel);
            TheUnitOfWork.Film.Update(film);
            TheUnitOfWork.Commit();

            return true;
        }

        public bool DeleteFilm(int id)
        {
            bool result = false;
            TheUnitOfWork.Film.Delete(id);
            result = TheUnitOfWork.Commit() > new int();
            return result;
        }

        public bool CheckFilmExists(FilmViewModel filmViewModel)
        {
            Film film = Mapper.Map<Film>(filmViewModel);
            return TheUnitOfWork.Film.CheckIsFilmExists(film);
        }
    }
}

