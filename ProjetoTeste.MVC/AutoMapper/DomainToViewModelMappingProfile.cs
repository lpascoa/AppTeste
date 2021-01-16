
using AutoMapper;
using ProjetoTeste.Domain.Entities;
using ProjetoTeste.MVC.ViewModels;

namespace ProjetoTeste.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Employee, EmployeeViewModel>();
        }
    }
}