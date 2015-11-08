using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
