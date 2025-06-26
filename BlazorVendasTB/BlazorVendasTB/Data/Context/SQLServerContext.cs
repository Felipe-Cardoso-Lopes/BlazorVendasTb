using BlazorVendasTB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasTB.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
