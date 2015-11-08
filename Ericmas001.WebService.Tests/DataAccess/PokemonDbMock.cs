using Ericmas001.WebService.DataAccess;
using OmgPokedex.DataTypes;
using System.Collections.Generic;
using System.Linq;

namespace Ericmas001.WebService.Tests.DataAccess
{
    class PokemonDbMock : IPokemonDb
    {
        readonly IEnumerable<IPokemon> m_Pokemons;
        public PokemonDbMock(IEnumerable<IPokemon> pokemons)
        {
            m_Pokemons = pokemons;
        }

        public IEnumerable<IPokemon> GetAllPokemons()
        {
            return m_Pokemons.ToArray();
        }

        public IPokemon GetPokemon(int id)
        {
            return m_Pokemons.SingleOrDefault(x => x.Id == id);
        }
    }
}
