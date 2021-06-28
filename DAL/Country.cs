using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class Country
    {
        public Country()
        {
            this.Films = new HashSet<Film>();
        }
    
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        
        public virtual ICollection<Film> Films { get; set; }
    }
}
