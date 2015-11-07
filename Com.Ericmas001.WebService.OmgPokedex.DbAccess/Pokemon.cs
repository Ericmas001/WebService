using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Com.Ericmas001.WebService.OmgPokedex.DbAccess
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Photo { get; set; }
        public string Generation { get; set; }
    }
}