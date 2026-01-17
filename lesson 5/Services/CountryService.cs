using lesson_5.Models;
namespace lesson_5.Services;

public class CountryService : ICountryService
{
    List<Country> Countries;
    public CountryService()
    {
        Countries = new List<Country>();
    }

    public Guid AddCountry(Country country)
    {
        country.Id = Guid.NewGuid();
        Countries.Add(country);
        return country.Id;
    }

    public bool DeleteCountry(Guid CountryId)
    {
        foreach (var country in Countries)
        {
            if (country.Id == CountryId)
            {
                Countries.Remove(country);
                return true;
            }
        }
        return false;
    }
    public List<Country> GetAllCountryes()
    {
        return Countries;
    }

    public Country? GetCountry(Guid coutryId)
    {
        foreach (var country in Countries)
        {
            if (country.Id == coutryId)
            {
                return country;
            }
        }
        return null;
    }
    public bool UpdateCountry(Country newCountries)
    {
        foreach (Country country in Countries)
        {
            if (newCountries.Id == country.Id)
            {
                country.Id = newCountries.Id;
                country.Name = newCountries.Name;
                country.Population = newCountries.Population;
            }
            return true;
        }
        return false;
    }






}
