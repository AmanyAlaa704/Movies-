using BL.Bases;
using DAL;
using BL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BL.Repositories
{
    public class DirectorRepository : BaseRepository<Director>
    {
        private DbContext contextDirector;
        public DirectorRepository(DbContext contextDirector) : base(contextDirector)
        {
            this.contextDirector = contextDirector;
        }
        public List<Director> GetAllDirector()
        {
            return GetAll().ToList();
        }
        public bool InsertDirector(Director director)
        {
            return Insert(director);
        }
        public void UpdateDirector(Director director)
        {
            Update(director);
        }
        public void DeleteDirector(int id)
        {
            Delete(id);
        }
        public bool CheckIsDirectorExists(Director director)
        {
            return GetAny(D => D.DirectorID == director.DirectorID);
        }
        public Director GetDirectorById(int id)
        {
            return GetFirstOrDefault(D => D.DirectorID == id);
        }



    }
}
