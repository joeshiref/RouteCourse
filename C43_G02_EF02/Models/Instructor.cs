using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF02.Models
{
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Bonus { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int Dept_ID { get; set; }
        [ForeignKey("Dept_ID")]
        public Department Department { get; set; }

        public ICollection<Course_Inst> CourseInstructors { get; set; }
    }
}
