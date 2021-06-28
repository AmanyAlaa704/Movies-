using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Director
    {
        public Director()
        {
            this.Films = new HashSet<Film>();
        }
    
        public int DirectorID { get; set; }
        public string DirectorName { get; set; }
        public DateTime DirectorDOB { get; set; }
        public string DirectorGender { get; set; }
        public string DirectorImage { get; set; }
    
        public virtual ICollection<Film> Films { get; set; }
    }
}
