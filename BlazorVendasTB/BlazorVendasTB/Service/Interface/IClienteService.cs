using BlazorVendasTB.Entities;

namespace BlazorVendasTB.Service.Interface
{
    public interface IClienteService
    {
        Task AdicionarAsync(Cliente cliente);
        Task AlterarAsync(Cliente cliente);
        Task ExcluirAsync(int id);
        Task<IEnumerable<Cliente>> ListarTodosAsync();
        Task<Cliente> PesquisarPorIdAsync(int id);
        Task<Cliente> PesquisarPorNomeAsync(string nome);
    }
}
