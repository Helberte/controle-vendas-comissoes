﻿using Microsoft.EntityFrameworkCore;
using controle_vendas_comissoes.Model.Db.Entidades;

namespace controle_vendas_comissoes.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Menu>? Menus { get; set; } = null;

        public DbSet<Estado>? Estados { get; set; } = null;

        public DbSet<Cidade>? Cidades { get; set; } = null;

        public DbSet<Classificacao>? Classificacoes { get; set; } = null;

        public DbSet<Pessoa>? Pessoas { get; set; } = null;

        public DbSet<Endereco>? Enderecos { get; set; } = null;

        public DbSet<UnidadePrimaria>? UnidadesPrimarias { get; set; } = null;

        public DbSet<Produto>? Produtos { get; set; } = null;

        public DbSet<TabelaPreco>? TabelaPrecos { get; set; } = null;

        public DbSet<ProdutoTabelaPreco>? ProdutoTabelaPrecos { get; set; } = null;

        public DbSet<Comissao>? Comissao { get; set; } = null;

        public DbSet<ComissaoItem>? ComissaoItem { get; set; } = null;

        public DbSet<EstadoComissao>? EstadoComissao { get; set; } = null;

        public DbSet<PedidoVenda>? PedidoVenda { get; set; } = null;

        public DbSet<PedidoVendaItem>? PedidoVendaItem { get; set; } = null;

        public DbSet<PessoaPedidoVenda>? PessoaPedidoVenda { get; set; } = null;

        public DbSet<PedidoVendaItemComissao>? PedidoVendaItemComissao { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=host,port;Database=banco;User ID=user;Password=senha;Trusted_Connection=False;TrustServerCertificate=True;");
        }
    }
}
