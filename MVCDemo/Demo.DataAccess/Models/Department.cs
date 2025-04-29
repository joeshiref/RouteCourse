using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Models
{
    public class Department : BaseEntity
    {
        public required string Name { get; set; }
        public string Code { get; set; } = null!;

        public string? Description { get; set; }

        public DateOnly CreationDate { get; set; }
    }
}
