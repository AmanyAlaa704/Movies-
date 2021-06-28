using BL.Bases;
using DAL;
using BL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BL.Repositories
{
    public class CountryRepository : BaseRepository<Country>
    {
        private DbContext countryContext;
        public CountryRepository(DbContext countryContext) : base(countryContext)
        {
            this.countryContext = countryContext;
        }
        public List<Country> GetAllCountry()
        {
            return GetAll().ToList();
        }



        public bool InsertCountry(Country country)
        {
            return Insert(country);
        }
        public void UpdateCountry(Country country)
        {
            Update(country);
        }
        public void DeleteCountry(int id)
        {
            Delete(id);
        }



        public bool CheckIsCountryExists(Country countries)
        {
            return GetAny(country => country.CountryID == country.CountryID);
        }
        public Country GetCountryById(int id)
        {
            return GetFirstOrDefault(country => country.CountryID == id);
        }



    }
}
