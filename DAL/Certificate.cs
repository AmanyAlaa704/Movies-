using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
 
    public class Certificate
    {
        public Certificate()
        {
            this.Films = new HashSet<Film>();
        }
    
        public int CertificateID { get; set; }
        public string Certificate1 { get; set; }
    
        public virtual ICollection<Film> Films { get; set; }
    }
}
