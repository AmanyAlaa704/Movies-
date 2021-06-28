using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BL.ViewModel
{
    public class RegisterViewodel
    {
        public int UserID { get; set; }
       
        [Required]
        [Display(Name ="User Name")]        
        public string UserName { get; set; }
        [Display(Name = "User Image")]
        public string UserImg { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("PasswordHash")]
        [Display(Name = "Confirm Password")]
        public string CompareUserPassword { get; set; }
        [Required]
        [Display(Name = "Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Pls Enter Valid Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public HttpPostedFileBase Image { get; set; }
    }
}
