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
        [Key]
        [Column(Order = 1)]
        public int Stud_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Course_ID { get; set; }

        public double Grade { get; set; }
    }
}
