using BlazorVendasTB.Data.Context;
using BlazorVendasTB.Entities;
using BlazorVendasTB.Service.Interface;

namespace BlazorVendasTB.Service.Implementation
{
    public class PedidoService : IPedidoService
    {
        private readonly SQLServerContext _context;

        public PedidoService(SQLServerContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Pedido>> ListarVendaAsync()
        {
            throw new NotImplementedException();
        }

        public Task RegistrarAsync(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
