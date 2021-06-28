using BL.Bases;
using BL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;



namespace BL.Repositories
{
    public class FilmRepository : BaseRepository<Film>
    {
        private DbContext filmContext;
        public FilmRepository(DbContext filmContext) : base(filmContext)
        {
            this.filmContext = filmContext;
        }
        public List<Film> GetAllFilm()
        {
            return GetAll().ToList();
        }



        public bool InsertFilm(Film film)
        {
            return Insert(film);
        }
        public void UpdateFilm(Film film)
        {
            Update(film);
        }
        public void DeleteFilm(int id)
        {
            Delete(id);
        }



        public bool CheckIsFilmExists(Film film)
        {
            return GetAny(F => F.FilmID == film.FilmID);
        }
        public Film GetFilmById(int id)
        {
            return GetFirstOrDefault(F => F.FilmID == id);
        }



    }
}