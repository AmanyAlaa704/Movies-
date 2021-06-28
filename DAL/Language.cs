using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  
    public class Language
    { 
        public Language()
        {
            this.Films = new HashSet<Film>();
        }
    
        public int LanguageID { get; set; }
        public string Language1 { get; set; }
    
        public virtual ICollection<Film> Films { get; set; }
    }
}
