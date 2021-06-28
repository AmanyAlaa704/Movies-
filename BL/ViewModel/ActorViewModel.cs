using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BL.ViewModel
{
    public class ActorViewModel
    {
       
        public int ActorID { get; set; }
       
        [Required]
        [Display(Name ="Name")]
        public string ActorName { get; set; }
        
        [Display(Name = "Actor Date Of Birth")]
        public DateTime ActorDOB { get; set; }
        
        [Required]
        [Display(Name ="Gender")]
        public string ActorGender { get; set; }
        
        [Display(Name = "Image")]
        public string ActorImage { get; set; }

        [Required]
        public HttpPostedFileBase Image { get; set; }

    }
}
