﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OmgPokedexEntities : DbContext
    {
        public OmgPokedexEntities()
            : base("name=OmgPokedexEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BackpackEntity> AllBackPacks { get; set; }
        public virtual DbSet<CatchedPokemonEntity> AllCatchedPokemons { get; set; }
        public virtual DbSet<PokemonSummaryEntity> AllPokemonSummaries { get; set; }
        public virtual DbSet<TrainerEntity> AllTrainers { get; set; }
        public virtual DbSet<UserEntity> AllUsers { get; set; }
    }
}
