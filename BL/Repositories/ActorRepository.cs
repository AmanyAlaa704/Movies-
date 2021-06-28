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
    public class ActorRepository : BaseRepository<Actor>
    {
        private DbContext ActorDb;
        public ActorRepository(DbContext ActorDb) : base(ActorDb)
        {
            this.ActorDb = ActorDb;
        }
        public List<Actor> GetAllActors()
        {
            return GetAll().ToList();
        }

        public bool InsertActor(Actor actor)
        {
            return Insert(actor);
        }
        public void UpdateActor(Actor actor)
        {
            Update(actor);
        }
        public void DeleteActor(int id)
        {
            Delete(id);
        }

 

        public bool CheckIsActorExists(Actor actor)
        {
            return GetAny(A => A.ActorID == actor.ActorID);
        }
        public Actor GetActorById(int id)
        {
            return GetFirstOrDefault(A => A.ActorID == id);
        }

    }
}
