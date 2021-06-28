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
    public class LanguageRepository : BaseRepository<Language>
    {
        private DbContext languageContext;
        public LanguageRepository(DbContext languageContext) : base(languageContext)
        {
            this.languageContext = languageContext;
        }
        public List<Language> GetAllLanguage()
        {
            return GetAll().ToList();
        }
        public bool InsertLanguage(Language language)
        {
            return Insert(language);
        }
        public void UpdateLanguage(Language language)
        {
            Update(language);
        }
        public void DeleteLanguage(int id)
        {
            Delete(id);
        }
        public bool CheckIsLanguageExists(Language language)
        {
            return GetAny(L=>L.Language1 ==language.Language1);
        }
        public Language GetLanguageById(int id)
        {
            return GetFirstOrDefault(L => L.LanguageID == id);
        }
    }
}
