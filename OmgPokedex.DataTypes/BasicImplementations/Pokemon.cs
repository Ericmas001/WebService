﻿using OmgPokedex.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
