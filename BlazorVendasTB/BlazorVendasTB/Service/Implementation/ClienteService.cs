using BlazorVendasTB.Data.Context;
using BlazorVendasTB.Entities;
using BlazorVendasTB.Service.Interface;

namespace BlazorVendasTB.Service.Implementation
{
    public class ClienteService : IClienteService
    {
        private readonly SQLServerContext _context;

        public ClienteService(SQLServerContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Cliente cliente)
        {
           _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<Cliente>> ListarTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> PesquisarPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> PesquisarPorNomeAsync(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
