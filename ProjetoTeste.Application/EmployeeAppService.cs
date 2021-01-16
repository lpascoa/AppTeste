
using System.Collections.Generic;
using ProjetoTeste.Application.Interface;
using ProjetoTeste.Domain.Entities;
using ProjetoTeste.Domain.Interfaces.Services;

namespace ProjetoTeste.Application
{
    public class EmployeeAppService : AppServiceBase<Employee>, IEmployeeAppService
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeAppService(IEmployeeService employeeService)
            : base(employeeService)
        {
            _employeeService = employeeService;
        }

        public IEnumerable<Employee> BuscarPorNome(string nome)
        {
            return _employeeService.BuscarPorNome(nome);
        }
    }
}