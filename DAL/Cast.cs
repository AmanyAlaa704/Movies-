using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class Cast
    {
        public Cast()
        {
            this.Actors = new HashSet<Actor>();
        }
        public int CastID { get; set; }
        public int FilmID { get; set; }
        public int CastActorID { get; set; }
        public string CastCharacterName { get; set; }  
  //      [Required]
//        public virtual Film Film { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }

    }
}
