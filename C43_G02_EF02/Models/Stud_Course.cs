using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF02.Models
{
    internal class Stud_Course
    {

        public int Stud_ID { get; set; }
        [ForeignKey("Stud_ID")]
        public Student Student { get; set; }

        public int Course_ID { get; set; }
        [ForeignKey("Course_ID")]
        public Course Course { get; set; }

        public double Grade { get; set; }


    }
}
