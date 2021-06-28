using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int FilmID { get; set; }
        public string CommentContent { get; set; }
        public int UserID { get; set; }
    
        public virtual Film Film { get; set; }
        public virtual ApplicationUserIdentity User { get; set; }
    }
}
