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
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/2/21/001Bulbasaur.png/250px-001Bulbasaur.png"
                },
                new Pokemon
                {
                    Id = 4,
                    Name="Charmander",
                    Type = "Fire",
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/7/73/004Charmander.png/250px-004Charmander.png"
                },
                new Pokemon
                {
                    Id = 7,
                    Name="Squirtle",
                    Type = "Water",
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/3/39/007Squirtle.png/250px-007Squirtle.png"
                },
                new Pokemon
                {
                    Id = 10,
                    Name="Caterpie",
                    Type = "Bug",
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/5/5d/010Caterpie.png/250px-010Caterpie.png"
                },
                new Pokemon
                {
                    Id = 25,
                    Name="Pikachu",
                    Type = "Electric",
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/0/0d/025Pikachu.png/250px-025Pikachu.png"
                },
                new Pokemon
                {
                    Id = 43,
                    Name="Oddish",
                    Type = "Grass / Poison",
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/4/43/043Oddish.png/250px-043Oddish.png"
                },
                new Pokemon
                {
                    Id = 52,
                    Name="Meowth",
                    Type = "Normal",
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/d/d6/052Meowth.png/250px-052Meowth.png"
                },
                new Pokemon
                {
                    Id = 54,
                    Name="Psyduck",
                    Type = "Water",
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/5/53/054Psyduck.png/250px-054Psyduck.png"
                },
                new Pokemon
                {
                    Id = 129,
                    Name="Magikarp",
                    Type = "Water",
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/0/02/129Magikarp.png/250px-129Magikarp.png"
                },
                new Pokemon
                {
                    Id = 143,
                    Name="Snorlax",
                    Type = "Normal",
                    Photo = "http://cdn.bulbagarden.net/upload/thumb/f/fb/143Snorlax.png/250px-143Snorlax.png"
                }};
    }
}