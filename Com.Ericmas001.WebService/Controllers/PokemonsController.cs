using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using Com.Ericmas001.WebService.Models;
using static System.String;

namespace Com.Ericmas001.WebService.Controllers
{
    public class PokemonsController : ApiController
    {
        // GET api/pokemons
        public IEnumerable<Pokemon> Get()
        {
            return Pokemon.AllPokemons;
        }

        // GET api/pokemons/5
        public Pokemon Get(int id)
        {
            var p = Pokemon.AllPokemons.SingleOrDefault(x => x.Id == id);
            return p ?? new Pokemon
                {
                    Id = id,
                    Name = "Unknown",
                    Type = "Unknown",
                    Photo = Empty
                };
        }

        // POST api/values
        public void Post([FromBody]Pokemon value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Pokemon value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
