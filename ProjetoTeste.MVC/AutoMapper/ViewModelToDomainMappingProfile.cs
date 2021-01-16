
using AutoMapper;
using ProjetoTeste.Domain.Entities;
using ProjetoTeste.MVC.ViewModels;

namespace ProjetoTeste.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Employee, EmployeeViewModel>();
        }
    }
}