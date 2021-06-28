using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModel
{
    public class CastViewModel
    {
        [Display(Name = "Character Name")]
        public string CastCharacterName { get; set; }
        [Display(Name = "Actor Name")]
        public string ActorName { get; set; }
        public string CastActorImage { get; set; }
        public int CastID { get; set; }
        public int FilmID { get; set; }
        public int CastActorID { get; set; }
    }
}
