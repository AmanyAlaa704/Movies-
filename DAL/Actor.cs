using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
 
    public class Actor
    {
   
    
        public int ActorID { get; set; }
        public string ActorName { get; set; }
        [DataTypeAttribute(DataType.Date)]
        public DateTime ActorDOB { get; set; }
        public string ActorGender { get; set; }       
        public string ActorImage { get; set; } = "defaultImage.jpg";
        public virtual Cast cast { set; get; }
    }
}
