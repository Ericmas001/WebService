using Ericmas001.WebService.DataAccess;
using OmgPokedex.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ericmas001.WebService.Tests.DataAccess
{
    class PokemonDbMock : IPokemonDb
    {
        IEnumerable<IPokemon> m_Pokemons;
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
