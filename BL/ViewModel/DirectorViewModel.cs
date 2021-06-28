using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BL.ViewModel
{
    public class DirectorViewModel
    {
        public int DirectorID { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string DirectorName { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DirectorDOB { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string DirectorGender { get; set; }

        [Display(Name = "Image")]
        public string DirectorImage { get; set; }
        [Required]
        public HttpPostedFileBase Image { get; set; }
    }
}
