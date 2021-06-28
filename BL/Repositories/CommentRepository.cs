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
    public class CommentRepository : BaseRepository<Comment>
    {
        private DbContext contextComment;
        public CommentRepository(DbContext contextComment) : base(contextComment)
        {
            this.contextComment = contextComment;
        }
        public List<Comment> GetAllComments()
        {
            return GetAll().ToList();
        }



        public bool InsertComment(Comment comment)
        {
            return Insert(comment);
        }
        public void UpdateComment(Comment comment)
        {
            Update(comment);
        }
        public void DeleteComment(int id)
        {
            Delete(id);
        }



        public bool CheckIsCommentExists(Comment comment)
        {
            return GetAny(com => com.CommentId == comment.CommentId);
        }
        public Comment GetCommentById(int id)
        {
            return GetFirstOrDefault(com => com.CommentId == id);
        }



    }
}