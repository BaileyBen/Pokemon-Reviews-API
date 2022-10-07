using PokemonReviewsAPI.Models;

namespace PokemonReviewsAPI.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        bool CountryExists(int id);
        bool CreateCountry(Country country);
        bool Save();
    }
}
