using BL.Bases;
using BL.ViewModel;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.AppServices
{
    public class ActorAppService : AppServiceBase
    {

        public List<ActorViewModel> GetAllActors()
        {

            return Mapper.Map<List<ActorViewModel>>(TheUnitOfWork.Actor.GetAllActors());
        }
        public ActorViewModel GetActor(int id)
        {
            return Mapper.Map<ActorViewModel>(TheUnitOfWork.Actor.GetActorById(id));
        }



        public bool SaveNewActor(ActorViewModel actorViewModel)
        {
            bool result = false;
            var actor = Mapper.Map<Actor>(actorViewModel);
            if (TheUnitOfWork.Actor.Insert(actor))
            {
                result = TheUnitOfWork.Commit() > new int();
            }
            return result;
        }


        public bool UpdateActor(ActorViewModel actorViewModel)
        {
            var actor = Mapper.Map<Actor>(actorViewModel);
            TheUnitOfWork.Actor.Update(actor);
            TheUnitOfWork.Commit();

            return true;
        }

        public bool DeleteActor(int id)
        {
            bool result = false;
            TheUnitOfWork.Actor.Delete(id);
            result = TheUnitOfWork.Commit() > new int();
            return result;
        }

        public bool CheckActorExists(ActorViewModel actorViewModel)
        {
            Actor actor = Mapper.Map<Actor>(actorViewModel);
            return TheUnitOfWork.Actor.CheckIsActorExists(actor);
        }

        
    }
}
