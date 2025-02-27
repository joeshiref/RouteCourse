using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF02.Models
{
    internal class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }

        public int Dep_Id { get; set; }
        public Department Department { get; set; }
    }
}
