using BlazorVendasTB.Entities;

namespace BlazorVendasTB.Service.Interface
{
    public interface IProdutoService
    {
        Task AdicionarAsync(Produto produto);
        Task AlterarAsync(Produto produto);
        Task ExcluirAsync(int id);
        Task<IEnumerable<Produto>> ListarTodosAsync();
        Task<Produto> PesquisarProdutoPorIdAsync(int id);
    }
}
