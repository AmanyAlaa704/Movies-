using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModel
{
    public class LanguageViewModel
    {
        [Display(Name = "ID")]
        public int LanguageID { get; set; }

        [Required]
        [Display(Name ="Language Name")]
        public string Language1 { get; set; }
    }
}
