using C43_G02_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF02.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.FName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(s => s.LName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(s => s.Age)
                .IsRequired();
            builder.Property(s => s.Address)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(s => s.Dep_Id)
                .IsRequired();
        }
    }
}
