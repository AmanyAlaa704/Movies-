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
    public class GenreRepository : BaseRepository<Genre>
    {
        private DbContext generContext;
        public GenreRepository(DbContext generContext) : base(generContext)
        {
            this.generContext = generContext;
        }
        public List<Genre> GetAllGenre()
        {
            return GetAll().ToList();
        }
        public bool InsertGenre(Genre genre)
        {
            return Insert(genre);
        }
        public void UpdateGenre(Genre genre)
        {
            Update(genre);
        }
        public void DeleteGenre(int id)
        {
            Delete(id);
        }
        public bool CheckIsGenreExists(Genre genre)
        {
            return GetAny(G => G.GenreId == genre.GenreId);
        }
        public Genre GetGenreById(int id)
        {
            return GetFirstOrDefault(G => G.GenreId == id);
        }
    }
}