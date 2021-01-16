using System.Collections.Generic;
using ProjetoTeste.Domain.Entities;

namespace ProjetoTeste.Domain.Interfaces.Repositories
{
    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
        IEnumerable<Employee> BuscarPorNome(string nome);
    }
}
