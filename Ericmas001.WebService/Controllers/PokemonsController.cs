using System.Collections.Generic;
using System.Web.Http;
using static System.String;
using OmgPokedex.DbAccess;

namespace Ericmas001.WebService.Controllers
{
    public class PokemonsController : ApiController
    {
        // GET api/pokemons
        public IEnumerable<Pokemon> Get()
        {
            return Pokemon.GetAllPokemons();
        }

        // GET api/pokemons/5
        public Pokemon Get(int id)
        {
            return Pokemon.GetPokemon(id) ?? new Pokemon
            {
                Id = id,
                Name = "Unknown",
                Type = "Unknown",
                Photo = Empty
            };
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
