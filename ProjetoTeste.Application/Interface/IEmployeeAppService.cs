
using System.Collections.Generic;
using ProjetoTeste.Domain.Entities;

namespace ProjetoTeste.Application.Interface
{
    public interface IEmployeeAppService : IAppServiceBase<Employee>
    {
        IEnumerable<Employee> BuscarPorNome(string nome);
    }
}