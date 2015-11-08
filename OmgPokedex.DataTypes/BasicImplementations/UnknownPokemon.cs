namespace OmgPokedex.DataTypes.BasicImplementations
{
    public class UnknownPokemon : Pokemon
    {
        public UnknownPokemon(int id)
        {
            Id = id;
            Name = "Unknown";
            Type = "Unknown";
            Photo = string.Empty;
            Generation = "Unknown";
        }
    }
}
