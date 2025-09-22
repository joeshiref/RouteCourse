using Demo.DataAccess.Entities.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Presistance.Data.Configuration.Departments
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(dept => dept.Id).UseIdentityColumn(10,10);
            builder.Property(dept => dept.Name).HasColumnType("varchar(20)");
            builder.Property(dept => dept.Code).HasColumnType("varchar(20)");
            builder.Property(dept => dept.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(dept => dept.LastModifiedOn).HasComputedColumnSql("GETDATE()");

            builder.HasMany(dept => dept.Employees)
                   .WithOne(emp => emp.Department)
                   .HasForeignKey(emp => emp.DepartmentId)
                   .OnDelete(DeleteBehavior.SetNull);

            

        }
    }
}
