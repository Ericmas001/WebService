using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using Ericmas001.WebService.DataAccess;
using OmgPokedex.DataTypes;
using OmgPokedex.DataTypes.BasicImplementations;

namespace Ericmas001.WebService.Controllers
{
    public class PokemonsController : ApiController
    {
        readonly IPokemonDb m_Database;

        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public PokemonsController() : this(new PokemonDatabase())
        {

        }
        public PokemonsController(IPokemonDb db)
        {
            m_Database = db;
        }

        // GET api/pokemons
        public IEnumerable<IPokemon> Get()
        {
            return m_Database.GetAllPokemons();
        }

        // GET api/pokemons/5
        public IPokemon Get(int id)
        {
            return m_Database.GetPokemon(id) ?? new UnknownPokemon(id);
        }

        //// POST api/values
        //public void Post([FromBody]Pokemon value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]Pokemon value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
