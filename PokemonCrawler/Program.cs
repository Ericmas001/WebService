using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCrawler
{
    static class Program
    {
        public static string Extract(this string text, string before, string after, int startindex = 0)
        {
            int ideb = text.IndexOf(before, startindex, StringComparison.Ordinal) + before.Length;
            if (ideb < before.Length)
                return null;
            int ifin = text.IndexOf(after, ideb, StringComparison.Ordinal);
            if (ifin < 0)
                return null;
            return text.Substring(ideb, ifin - ideb);
        }
        static void Main(string[] args)
        {

            WebRequest request = WebRequest.Create("http://bulbapedia.bulbagarden.net/wiki/List_of_Pokémon_by_National_Pokédex_number");
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            string html = String.Empty;
            using (StreamReader sr = new StreamReader(data))
            {
                html = sr.ReadToEnd();
            }

            string useful = html.Extract("id=\"List_of_Pok.C3.A9mon_by_National_Pok.C3.A9dex_number\"", "id=\"See_also\"");
            
            string[] generations = useful.Replace("id=\"Generation", "|").Split('|').Skip(1).ToArray();
            Dictionary<string, Pokemon[]> allGenerations = new Dictionary<string, Pokemon[]>();

            foreach (string g in generations)
            {
                string title = g.Extract("title=\"", "\">");
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} {title} ...");
                Pokemon[] pokemons = g.Replace("<tr style=\"background:#FFFFFF;\">", "|").Split('|').Skip(1).ToArray().Select(l => new Pokemon(title,l.Replace("<td", "|").Split('|').Skip(1).ToArray())).ToArray();
                allGenerations.Add(title, pokemons);
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} {title} done !");
            }

            using (StreamWriter sw = File.CreateText(@"D:\Pokemons.txt"))
            {
                foreach (var pokemons in allGenerations.Values)
                    foreach (var p in pokemons)
                        sw.WriteLine($"{p.Id:000};{p.Name};{p.Generation};{String.Join(", ", p.Types)};{p.ImageURL}");
            }
        }

        class Pokemon
        {
            public string Generation { get; }
            public int Id { get; }

            public string Name { get; }

            public string ImageURL { get; }

            public string[] Types { get; }

            internal Pokemon(string generation, string[] crawledData)
            {
                Generation = generation;
                Id = int.Parse(crawledData[1].Extract("#", "<").Trim());
                Name = crawledData[3].Extract("\">", "<").Trim();
                Types = crawledData.Skip(4).Select(x => x.Extract("title=\""," (")).ToArray();
                var detailUrl = "http://bulbapedia.bulbagarden.net/wiki/" + crawledData[2].Extract("/wiki/","\"");

                WebRequest request = WebRequest.Create("http://bulbapedia.bulbagarden.net/wiki/" + crawledData[2].Extract("/wiki/", "\""));
                WebResponse response = request.GetResponse();
                Stream data = response.GetResponseStream();
                string html = String.Empty;
                using (StreamReader sr = new StreamReader(data))
                {
                    html = sr.ReadToEnd();
                    ImageURL = html.Extract("Pok%C3%A9mon_category", "width=\"250\" height=\"250\"").Extract("src=\"","\"");
                }
            }

            public override string ToString()
            {
                return $"#{Id:000} {Name} ({String.Join(", ",Types)})";
            }
        }
    }
}
