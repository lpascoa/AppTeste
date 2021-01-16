using System;

namespace ProjetoTeste.Domain.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public string EmployeeNumber { get; set; }
    }
}
