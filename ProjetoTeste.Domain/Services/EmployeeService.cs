using System.Collections.Generic;
using System.Linq;
using ProjetoTeste.Domain.Entities;
using ProjetoTeste.Domain.Interfaces.Repositories;
using ProjetoTeste.Domain.Interfaces.Services;

namespace ProjetoTeste.Domain.Services
{
    public class EmployeeService : ServiceBase<Employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
            : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> BuscarPorNome(string nome)
        {
            return _employeeRepository.BuscarPorNome(nome);
        }
    }
}
