using BlazorVendasTB.Entities;

namespace BlazorVendasTB.Service.Interface
{
    public interface IFuncionarioService
    {
        Task AdicionarAsync(Funcionario funcionario);
        Task AlterarAsync(Funcionario funcionario);
        Task ExcluirAsync(int id);
        Task<IEnumerable<Funcionario>> ListarTodosAsync();
        Task<Funcionario> PesquisarPorIdAsync(int id);
        Task<Funcionario> PesquisarPorNomeAsync(string nome);
    }
}
