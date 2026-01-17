using lesson_5.Models;

namespace lesson_5.Services;

public interface ICountryService
{
    public Guid AddCountry(Country countrt);
    public bool UpdateCountry(Country country);
    public bool DeleteCountry(Guid countryId);
    public Country? GetCountry(Guid countryId);
    public List<Country> GetAllCountryes();
}
