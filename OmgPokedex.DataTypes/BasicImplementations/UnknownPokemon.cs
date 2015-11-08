using OmgPokedex.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
