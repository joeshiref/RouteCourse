using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C43_G02_EF02.Models;
using C43_G02_EF02.Configurations;

namespace C43_G02_EF02.Data
{
    internal class SchoolDBContext : DbContext
    {
        
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CPC-youkh-QCOP2;Database=SchoolDB;Integrated Security=true;TrustServerCertificate=True;");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfigurations());

            modelBuilder.Entity<Course>()
                .ToTable("CoursesTable")
                .Property(c => c.Name)
                .HasColumnName("CourseName")
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Department>()
                .ToTable("DepartmentTable")
                .Property(d => d.HiringDate)
                .HasColumnType("datetime2");


            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.Inst_ID, ci.Course_ID });

            modelBuilder.Entity<Topic>()
                .ToTable("TopicsTable");

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Inst> CourseInstructors { get; set; }
        public DbSet<Topic> Topics { get; set; }

    }
}
