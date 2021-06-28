using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BL.ViewModel;
using BL.Bases;

namespace BL.AppServices
{
    public class CountryAppService : AppServiceBase
    {


        public List<CountryViewModel> GetAllCountries()
        {

            return Mapper.Map<List<CountryViewModel>>(TheUnitOfWork.Country.GetAllCountry());
        }
        public CountryViewModel GetCountry(int id)
        {
            return Mapper.Map<CountryViewModel>(TheUnitOfWork.Country.GetCountryById(id));
        }

        public bool SaveNewCountry(CountryViewModel countryViewModel)
        {
            bool result = false;
            var country = Mapper.Map<Country>(countryViewModel);
            if (TheUnitOfWork.Country.Insert(country))
            {
                result = TheUnitOfWork.Commit() > new int();
            }
            return result;
        }

        public bool UpdateCountry(CountryViewModel countryViewModel)
        {
            var country = Mapper.Map<Country>(countryViewModel);
            TheUnitOfWork.Country.Update(country);
            TheUnitOfWork.Commit();

            return true;
        }

        public bool DeleteCountry(int id)
        {
            bool result = false;
            TheUnitOfWork.Country.Delete(id);
            result = TheUnitOfWork.Commit() > new int();
            return result;
        }

        public bool CheckCountryExists(CountryViewModel countryViewModel)
        {
            Country country = Mapper.Map<Country>(countryViewModel);
            return TheUnitOfWork.Country.CheckIsCountryExists(country);
        }
    }
}

