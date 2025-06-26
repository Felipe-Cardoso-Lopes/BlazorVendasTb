using BlazorVendasTB.Entities;

namespace BlazorVendasTB.Service.Interface
{
    public interface IPedidoService
    {
        Task RegistrarAsync(Pedido pedido);
        Task<IEnumerable<Pedido>> ListarVendaAsync();
    }
}
