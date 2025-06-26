using BlazorVendasTB.Entities;

namespace BlazorVendasTB.Service.Interface
{
    public interface IItemVendaService
    {
        Task InserirItemAsync(ItemVenda itemvenda);
        Task ExcluirItemAsync(int id);
    }
}