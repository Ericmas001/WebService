namespace Com.Ericmas001.WebService.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } 
        public string Photo { get; set; }

        public static Pokemon[] PokemonListMock = {
                new Pokemon
                {
                    Id = 1,
                    Name="Bulbasaur",
                    Type = "Grass / Poison",
                    Photo = "http://cdn.bulbagarden.net/upload/e/ec/001MS.png"
                },
                new Pokemon
                {
                    Id = 4,
                    Name="Charmander",
                    Type = "Fire",
                    Photo = "http://cdn.bulbagarden.net/upload/b/bb/004MS.png"
                },
                new Pokemon
                {
                    Id = 7,
                    Name="Squirtle",
                    Type = "Water",
                    Photo = "http://cdn.bulbagarden.net/upload/9/92/007MS.png"
                },
                new Pokemon
                {
                    Id = 10,
                    Name="Caterpie",
                    Type = "Bug",
                    Photo = "http://cdn.bulbagarden.net/upload/6/69/010MS.png"
                },
                new Pokemon
                {
                    Id = 25,
                    Name="Pikachu",
                    Type = "Electric",
                    Photo = "http://cdn.bulbagarden.net/upload/0/0f/025MS.png"
                },
                new Pokemon
                {
                    Id = 43,
                    Name="Oddish",
                    Type = "Grass / Poison",
                    Photo = "http://cdn.bulbagarden.net/upload/a/a5/043MS.png"
                },
                new Pokemon
                {
                    Id = 52,
                    Name="Meowth",
                    Type = "Normal",
                    Photo = "http://cdn.bulbagarden.net/upload/5/50/052MS.png"
                },
                new Pokemon
                {
                    Id = 54,
                    Name="Psyduck",
                    Type = "Water",
                    Photo = "http://cdn.bulbagarden.net/upload/6/6b/054MS.png"
                },
                new Pokemon
                {
                    Id = 129,
                    Name="Magikarp",
                    Type = "Water",
                    Photo = "http://cdn.bulbagarden.net/upload/7/7c/129MS.png"
                },
                new Pokemon
                {
                    Id = 142,
                    Name="Snorlax",
                    Type = "Normal",
                    Photo = "http://cdn.bulbagarden.net/upload/d/d6/143MS.png"
                }};
    }
}