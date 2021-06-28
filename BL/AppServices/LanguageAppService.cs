using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Bases;
using DAL;
using BL.ViewModel;

namespace BL.AppServices
{

    public class LanguageAppService : AppServiceBase
    {

        public List<LanguageViewModel> GetAllLanguages()
        {

            return Mapper.Map<List<LanguageViewModel>>(TheUnitOfWork.Language.GetAllLanguage());
        }
        public LanguageViewModel GetLanguage(int id)
        {
            return Mapper.Map<LanguageViewModel>(TheUnitOfWork.Language.GetLanguageById(id));
        }

        public bool SaveNewLanguage(LanguageViewModel languageViewModel)
        {
            bool result = false;
            var language = Mapper.Map<Language>(languageViewModel);
            if (TheUnitOfWork.Language.Insert(language))
            {
                result = TheUnitOfWork.Commit() > new int();
            }
            return result;
        }

        public bool UpdateLanguage(LanguageViewModel languageViewModel)
        {
            var language = Mapper.Map<Language>(languageViewModel);
            TheUnitOfWork.Language.Update(language);
            TheUnitOfWork.Commit();

            return true;
        }

        public bool DeleteLanguage(int id)
        {
            bool result = false;
            TheUnitOfWork.Language.Delete(id);
            result = TheUnitOfWork.Commit() > new int();
            return result;
        }

        public bool CheckLanguageExists(LanguageViewModel languageViewModel)
        {
            Language language = Mapper.Map<Language>(languageViewModel);
            return TheUnitOfWork.Language.CheckIsLanguageExists(language);
        }
    }
}
