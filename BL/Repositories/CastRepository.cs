using BL.Bases;
using BL.ViewModel;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repositories
{
    public class CastRepository: BaseRepository<Cast>
    {
        private DbContext castContext;
        public CastRepository(DbContext castContext):base(castContext)
        {
            this.castContext = castContext;
        }

        public List<Cast> GetAllCasts()
        {
            return GetAll().ToList();
        }

        public bool InsertCast(Cast cast)
        {
            return Insert(cast);
        }
        public void UpdateCast(Cast cast)
        {
            Update(cast);
        }
        public void DeleteCast(int id)
        {
            Delete(id);
        }

        public bool CheckIsCastExists(Cast cast)
        {
            return GetAny(C => C.CastID == cast.CastID);
        }
        public Cast GetCastById(int id)
        {
            return GetFirstOrDefault(C => C.CastID == id);
        }

        public void DeleteList(List<CastViewModel> castViewModels)
        {
            DeleteList(castViewModels);
        }
    }
}
