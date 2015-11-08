namespace OmgPokedex.DataTypes
{
    public interface IPokemon
    {
        int Id { get; }
        string Name { get; }
        string Type { get; }
        string Photo { get; }
        string Generation { get; }
    }
}
