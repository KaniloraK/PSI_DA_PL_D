﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestGest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestGestContainer : DbContext
    {
        public RestGestContainer()
            : base("name=RestGestContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Restaurante> Restaurantes { get; set; }
        public virtual DbSet<ItemMenu> ItemMenus { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Pagamento> Pagamentos { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<MetodoPagamento> MetodoPagamentos { get; set; }
        public virtual DbSet<Morada> Moradas { get; set; }
    }
}
