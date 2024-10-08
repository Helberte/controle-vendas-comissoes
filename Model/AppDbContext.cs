﻿using Microsoft.EntityFrameworkCore;
using controle_vendas_comissoes.Model.Db.Entidades;

namespace controle_vendas_comissoes.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Menu>? Menus { get; set; } = null;

        public DbSet<Estado>? Estados { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=mundo_verde_vendas;User ID=sa;Password=H*bni/_#01;Trusted_Connection=False;TrustServerCertificate=True;");
        }
    }
}
