
using System.Collections.Generic;
using ProjetoTeste.Domain.Entities;

namespace ProjetoTeste.Domain.Interfaces.Services
{
    public interface IEmployeeService : IServiceBase<Employee>
    {
        IEnumerable<Employee> BuscarPorNome(string nome);
    }
}
