using BL.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BL.ViewModel;

namespace BL.AppServices
{
    public class CastAppService : AppServiceBase
    {

        public List<CastViewModel> GetAllCasts()
        {

            return Mapper.Map<List<CastViewModel>>(TheUnitOfWork.Cast.GetAllCasts());
        }
        public CastViewModel GetCast(int id)
        {
            return Mapper.Map<CastViewModel>(TheUnitOfWork.Cast.GetCastById(id));
        }

        public bool SaveNewCast(CastViewModel castViewModel)
        {
            bool result = false;
            var cast = Mapper.Map<Cast>(castViewModel);
            if (TheUnitOfWork.Cast.Insert(cast))
            {
                result = TheUnitOfWork.Commit() > new int();
            }
            return result;
        }

        public bool UpdateCast(CastViewModel castViewModel)
        {
            var cast = Mapper.Map<Cast>(castViewModel);
            TheUnitOfWork.Cast.Update(cast);
            TheUnitOfWork.Commit();

            return true;
        }

        public bool DeleteCast(int id)
        {
            bool result = false;
            TheUnitOfWork.Cast.Delete(id);
            result = TheUnitOfWork.Commit() > new int();
            return result;
        }
        public void DeleteCastList(List<CastViewModel> castViewModels)
        {
            TheUnitOfWork.Cast.DeleteList(castViewModels);

        }


        public bool CheckCastExists(CastViewModel castViewModel)
        {
            Cast cast = Mapper.Map<Cast>(castViewModel);
            return TheUnitOfWork.Cast.CheckIsCastExists(cast);
        }
    }
}
