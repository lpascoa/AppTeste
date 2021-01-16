
using System.Collections.Generic;
using System.Linq;
using ProjetoTeste.Domain.Entities;
using ProjetoTeste.Domain.Interfaces.Repositories;

namespace ProjetoTeste.Infra.Data.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public IEnumerable<Employee> BuscarPorNome(string nome)
        {
            return Db.Employee.Where(p => p.FirstName.Contains(nome));
        }
    }
}
