using OmgPokedex.DataTypes.BasicImplementations;
using System.Collections.Generic;
using System.Linq;

namespace OmgPokedex.DbAccess
{
    public static class Pokemons
    {
        public static IEnumerable<Pokemon> GetAllPokemons()
        {
            using (var context = new OmgPokedexEntities())
            {
                return context.AllPokemonSummaries.AsEnumerable().Select(GetPokemon).ToArray();
            }
        }
        public static Pokemon GetPokemon(int id)
        {
            using (var context = new OmgPokedexEntities())
            {
                return context.AllPokemonSummaries.Where(x => x.PokedexNo == id).AsEnumerable().Select(GetPokemon).SingleOrDefault();
            }
        }

        private static Pokemon GetPokemon(PokemonSummaryEntity x)
        {
            return new Pokemon
            {
                Id = x.PokedexNo,
                Name = x.Name,
                Type = x.Type,
                Photo = x.ImageUrl,
                Generation = x.Generation
            };
        }
    }
}