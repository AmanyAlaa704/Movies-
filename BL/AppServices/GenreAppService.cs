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
   public class GenreAppService : AppServiceBase
    {

        public List<GenreViewModel> GetAllGenres()
        {

            return Mapper.Map<List<GenreViewModel>>(TheUnitOfWork.Genre.GetAllGenre());
        }
        public GenreViewModel GetGenre(int id)
        {
            return Mapper.Map<GenreViewModel>(TheUnitOfWork.Genre.GetGenreById(id));
        }

        public bool SaveNewGenre(GenreViewModel genreViewModel)
        {
            bool result = false;
            var genre = Mapper.Map<Genre>(genreViewModel);
            if (TheUnitOfWork.Genre.Insert(genre))
            {
                result = TheUnitOfWork.Commit() > new int();
            }
            return result;
        }

        public bool UpdateGenre(GenreViewModel genreViewModel)
        {
            var genre = Mapper.Map<Genre>(genreViewModel);
            TheUnitOfWork.Genre.Update(genre);
            TheUnitOfWork.Commit();

            return true;
        }

        public bool DeleteGenre(int id)
        {
            bool result = false;
            TheUnitOfWork.Genre.Delete(id);
            result = TheUnitOfWork.Commit() > new int();
            return result;
        }

        public bool CheckGenreExists(GenreViewModel genreViewModel)
        {
            Genre genre = Mapper.Map<Genre>(genreViewModel);
            return TheUnitOfWork.Genre.CheckIsGenreExists(genre);
        }
    }
}
