using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModel
{
   public class CountryViewModel
    {
        public int CountryID { get; set; }
        [Required]
        [Display(Name ="Country Name")]
        public string CountryName { get; set; }
    }
}
