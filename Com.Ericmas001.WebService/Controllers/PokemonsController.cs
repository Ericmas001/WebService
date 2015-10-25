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
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Com.Ericmas001.WebService.Content.Pokemons.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                Pokemon[] pokemons = result.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Split(';')).GroupBy(x => x[0]).Select(GeneratePokemon).ToArray();
                return pokemons;
            }
        }

        private Pokemon GeneratePokemon(IGrouping<string, string[]> arg)
        {
            var master = arg.First();
            var types = Join(", ", arg.Select(x => x[3]));
            return new Pokemon() {Id = int.Parse(master[0]),Name=master[1],Photo=master[4],Type=types};
        }

        // GET api/pokemons/5
        public Pokemon Get(int id)
        {
            var p = Pokemon.PokemonListMock.SingleOrDefault(x => x.Id == id);
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
