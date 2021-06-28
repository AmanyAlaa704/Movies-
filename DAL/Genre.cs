using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public  class Genre
    {
        public Genre()
        {
            this.Films = new HashSet<Film>();
        }
    
        public int GenreId { get; set; }
        public string GenreName { get; set; }
    
        public virtual ICollection<Film> Films { get; set; }
    }
}
