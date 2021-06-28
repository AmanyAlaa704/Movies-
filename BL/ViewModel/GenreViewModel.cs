using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModel
{
    public class GenreViewModel
    {
        public int GenreId { get; set; }
        [Required]
        [Display(Name ="Category Name")]
        public string GenreName { get; set; }

    }
}
