namespace OmgPokedex.DataTypes.BasicImplementations
{
    public class Pokemon : IPokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Photo { get; set; }
        public string Generation { get; set; }
    }
}
