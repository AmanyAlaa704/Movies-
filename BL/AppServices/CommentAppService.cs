using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BL.ViewModel;
using BL.Bases;

namespace BL.AppServices
{
    public class CommentAppService: AppServiceBase
    {

        public List<CommentViewModel> GetAllComments()
        {

            return Mapper.Map<List<CommentViewModel>>(TheUnitOfWork.Comment.GetAllComments());
        }
        public CommentViewModel GetComment(int id)
        {
            return Mapper.Map<CommentViewModel>(TheUnitOfWork.Comment.GetCommentById(id));
        }

        public bool SaveNewComment(CommentViewModel commentViewModel)
        {
            bool result = false;
            var comment = Mapper.Map<Comment>(commentViewModel);
            if (TheUnitOfWork.Comment.Insert(comment))
            {
                result = TheUnitOfWork.Commit() > new int();
            }
            return result;
        }
   
        public bool UpdateComment(CommentViewModel commentViewModel)
        {
            var comment = Mapper.Map<Comment>(commentViewModel);
            TheUnitOfWork.Comment.Update(comment);
            TheUnitOfWork.Commit();

            return true;
        }

        public bool DeleteComment(int id)
        {
            bool result = false;
            TheUnitOfWork.Comment.Delete(id);
            result = TheUnitOfWork.Commit() > new int();
            return result;
        }

        public bool CheckCommentExists(CommentViewModel commentViewModel)
        {
            Comment comment = Mapper.Map<Comment>(commentViewModel);
            return TheUnitOfWork.Comment.CheckIsCommentExists(comment);
        }
    }
}
