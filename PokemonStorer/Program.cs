using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Com.Ericmas001.WebService.OmgPokedex.DbAccess;
using static System.String;

namespace PokemonStorer
{
    class Program
    {
        static void Main(string[] args)
        {
            File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Pokemons.txt").Select(x => x.Split(';')).GroupBy(x => x[0]).Select(GeneratePokemon).ToList().ForEach(AddToDatabase);
        }

        private static Pokemon GeneratePokemon(IGrouping<string, string[]> arg)
        {
            var master = arg.First();
            var types = Join(" / ", arg.Select(x => x[3]));
            return new Pokemon
            {
                Id = int.Parse(master[0]),
                Name = master[1],
                Generation = master[2],
                Photo = master[4],
                Type = types
            };
        }
        private static void AddToDatabase(Pokemon p)
        {
            p.AddToDatabase();
            Console.WriteLine("{0} - {1}", p.Id, p.Name);
        }
    }
}
