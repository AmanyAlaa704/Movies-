using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModel
{
    public class CertificateViewModel
    {
        public int CertificateID { get; set; }
        [Display(Name= "Certificatation Name")]
        [Required]
        public string Certificate1 { get; set; }
    }
}
