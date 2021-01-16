
using System.Data.Entity.ModelConfiguration;
using ProjetoTeste.Domain.Entities;

namespace ProjetoTeste.Infra.Data.EntityConfig
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(c => c.EmployeeId);

            Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Surname)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();

        }
    }
}