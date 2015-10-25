using System;
using System.IO;
using System.Linq;
using System.Reflection;
using static System.String;

namespace Com.Ericmas001.WebService.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Photo { get; set; }

        private static Pokemon[] m_AllPokemons;

        public static Pokemon[] AllPokemons => m_AllPokemons ?? GetPokemons();

        private static Pokemon[] GetPokemons()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Com.Ericmas001.WebService.Content.Pokemons.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    Pokemon[] pokemons = result.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Split(';')).GroupBy(x => x[0]).Select(GeneratePokemon).ToArray();
                    m_AllPokemons = pokemons;
                    return pokemons;
                }
        }

        private static Pokemon GeneratePokemon(IGrouping<string, string[]> arg)
        {
            var master = arg.First();
            var types = Join(", ", arg.Select(x => x[3]));
            return new Pokemon
            {
                Id = int.Parse(master[0]),
                Name = master[1],
                Photo = master[4],
                Type = types
            };
        }
    }
}