using OmgPokedex.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ericmas001.WebService.DataAccess
{
    public interface IPokemonDb
    {
        IEnumerable<IPokemon> GetAllPokemons();
        IPokemon GetPokemon(int id);
    }
}
