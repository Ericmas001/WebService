using OmgPokedex.DataTypes;
using OmgPokedex.DbAccess;
using System.Collections.Generic;

namespace Ericmas001.WebService.DataAccess
{
    class PokemonDatabase : IPokemonDb
    {
        public IEnumerable<IPokemon> GetAllPokemons()
        {
            return Pokemons.GetAllPokemons();
        }

        public IPokemon GetPokemon(int id)
        {
            return Pokemons.GetPokemon(id);
        }
    }
}