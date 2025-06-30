using Demo.DataAccess.Entities.Common.Enums;
using Demo.DataAccess.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Presistance.Data.Configuration.Employees
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(e => e.Address).HasColumnType("nvarchar(200)");
            builder.Property(e => e.Salary).HasColumnType("decimal(8,2)");
            builder.Property(e => e.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.LastModifiedOn).HasComputedColumnSql("GETDATE()");

            builder.Property(e => e.Gender)
                .HasConversion(gender => gender.ToString(),
                (gender) => (Gender)Enum.Parse(typeof(Gender), gender)
                );
            builder.Property(e => e.EmployeeType)
                .HasConversion(empType => empType.ToString(),
                (empType) => (EmployeeType)Enum.Parse(typeof(EmployeeType), empType)
                );
        }
    }
}
