using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class Film
    {
        public Film()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public DateTime FilmReleaseDate { get; set; }
        public int FilmDirectorID { get; set; }
        public int FilmLanguageID { get; set; }
        public int FilmCountryID { get; set; }
        public string FilmSynopsis { get; set; }
        public int FilmRunTimeMinutes { get; set; }
        public int FilmCertificateID { get; set; }
        public int FilmGenreID { get; set; }
        public string FilmImg { get; set; }
        public string FilmMovie { get; set; }
        public string FilmPromo { get; set; }
        public int FilmOscarNominations { get; set; }
        public int FilmOscarWins { get; set; }

        //public int CastID { get; set; } 
       // [Required]
        //public virtual Cast Casts { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Country Country { get; set; }
        public virtual Director Director { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Language Language { get; set; }
    }
}
