//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OmgPokedex.DbAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class PokemonSummaryEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PokemonSummaryEntity()
        {
            this.CatchedPokemonsOfPokemonSummary = new HashSet<CatchedPokemonEntity>();
        }
    
        public int IdPokemonSummary { get; set; }
        public int PokedexNo { get; set; }
        public string Name { get; set; }
        public string Generation { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatchedPokemonEntity> CatchedPokemonsOfPokemonSummary { get; set; }
    }
}