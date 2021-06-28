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
    public class DirectorAppService:AppServiceBase
    {
        public List<DirectorViewModel> GetAllDirectors()
        {

            return Mapper.Map<List<DirectorViewModel>>(TheUnitOfWork.Director.GetAllDirector());
        }
        public DirectorViewModel GetDirector(int id)
        {
            return Mapper.Map<DirectorViewModel>(TheUnitOfWork.Director.GetDirectorById(id));
        }

        public bool SaveNewDirector(DirectorViewModel directorViewModel)
        {
            bool result = false;
            var director = Mapper.Map<Director>(directorViewModel);
            if (TheUnitOfWork.Director.Insert(director))
            {
                result = TheUnitOfWork.Commit() > new int();
            }
            return result;
        }

        public bool UpdateDirector(DirectorViewModel directorViewModel)
        {
            var director = Mapper.Map<Director>(directorViewModel);
            TheUnitOfWork.Director.Update(director);
            TheUnitOfWork.Commit();

            return true;
        }

        public bool DeleteDirector(int id)
        {
            bool result = false;
            TheUnitOfWork.Director.Delete(id);
            result = TheUnitOfWork.Commit() > new int();
            return result;
        }

        public bool CheckDirectorExists(DirectorViewModel directorViewModel)
        {
            Director director = Mapper.Map<Director>(directorViewModel);
            return TheUnitOfWork.Director.CheckIsDirectorExists(director);
        }
    }
}


