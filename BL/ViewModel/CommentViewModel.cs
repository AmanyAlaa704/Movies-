using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModel
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }
        public int FilmID { get; set; }      
       
        [Display(Name ="Comment")]
        public string CommentContent { get; set; }
        public string User_Id { get; set; }
        
    }
}
