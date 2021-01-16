
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoTeste.MVC.ViewModels
{
    public class EmployeeViewModel
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-Mail")]
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public string EmployeeNumber { get; set; }
    }
}