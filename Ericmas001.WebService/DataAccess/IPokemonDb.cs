using OmgPokedex.DataTypes;
using System.Collections.Generic;

namespace Ericmas001.WebService.DataAccess
{
    public interface IPokemonDb
    {
        IEnumerable<IPokemon> GetAllPokemons();
        IPokemon GetPokemon(int id);
    }
}
