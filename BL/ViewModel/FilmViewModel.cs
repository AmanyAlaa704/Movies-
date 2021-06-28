using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BL.ViewModel
{
    public class FilmViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmID { get; set; }
        [Required]
        [Display(Name = "Film Name")]
        public string FilmName { get; set; }
        [Required]
        [Display(Name = "Film Release Date")]
        public DateTime FilmReleaseDate { get; set; }
        [Required]
        [Display(Name = "Film Director")]

        public int FilmDirectorID { get; set; }
        [Required]
        [Display(Name = "Film Language")]

        public int FilmLanguageID { get; set; }
        [Required]
        [Display(Name = "Film Country")]

        public int FilmCountryID { get; set; }
        [Required]

        [Display(Name = "Film Synopsis")]
        public string FilmSynopsis { get; set; }
        [Required]
        [Display(Name = "Film Length")]
        public int FilmRunTimeMinutes { get; set; }
        [Required]
        [Display(Name = "Film Certificate")]
        public int FilmCertificateID { get; set; }
        [Required]
        [Display(Name = "Film Genre")]

        public int FilmGenreID { get; set; }
        
        [Display(Name = "Image")]
        public string FilmImg { get; set; }
        [Required]
        [Display(Name = "Video")]
        public string FilmMovie { get; set; }
        [Required]
        [Display(Name = "Promo")]
        public string FilmPromo { get; set; }
        [Required]
        [Display(Name = "Times of Nomnating to Oscar")]
        public int FilmOscarNominations { get; set; }
        [Required]
        [Display(Name = "Times of Wining Oscar")]
        public int FilmOscarWins { get; set; }
        public HttpPostedFileBase Image { get; set; }
    }
}