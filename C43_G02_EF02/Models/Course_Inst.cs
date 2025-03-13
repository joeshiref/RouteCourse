using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF02.Models
{
    internal class Course_Inst
    {
        public int Inst_ID { get; set; }
        [ForeignKey("Inst_ID")]
        public Instructor Instructor { get; set; }
        public int Course_ID { get; set; }
        [ForeignKey("Course_ID")]
        public Course Course { get; set; }
        public string Evaluate { get; set; }
    }
}
