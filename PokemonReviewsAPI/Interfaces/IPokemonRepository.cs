using PokemonReviewsAPI.Models;

namespace PokemonReviewsAPI.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemonName(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int id);
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        bool Save();
    }
}
