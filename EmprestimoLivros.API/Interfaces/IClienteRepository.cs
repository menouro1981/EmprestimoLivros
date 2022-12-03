using EmprestimoLivros.API.Controllers.NovaPasta;

namespace EmprestimoLivros.API.Interfaces
{
    public interface IClienteRepository
    {
        void Incluir (Cliente cliente);

        void Alterar (Cliente cliente);

        void Excluir (Cliente cliente);

        Task<Cliente> SelecionarbyPk(int id);
        Task<IEnumerable<Cliente>> SelecionarTodos();
        Task<bool> SaveAllAsync();
    }
}
