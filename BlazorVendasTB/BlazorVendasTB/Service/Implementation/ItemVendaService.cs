using BlazorVendasTB.Data.Context;
using BlazorVendasTB.Entities;
using BlazorVendasTB.Service.Interface;

namespace BlazorVendasTB.Service.Implementation
{
    public class ItemVendaService : IItemVendaService
    {
        private readonly SQLServerContext _context;

        public ItemVendaService(SQLServerContext context)
        {
            _context = context;
        }

        public async Task ExcluirItemAsync(int id)
        {
            var itemVenda = await _context.Funcionarios.FindAsync(id);
            if (itemVenda != null)
            {
                _context.Funcionarios.Remove(itemVenda);
                await _context.SaveChangesAsync();
            }
        }

        public async Task InserirItemAsync(ItemVenda itemVenda)
        {
            _context.ItemVenda.Add(itemVenda);
            await _context.SaveChangesAsync();
        }
    }
}
