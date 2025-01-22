using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_OOP06
{
    internal interface IRectangle : IShape
    {
        double Length { get; }
        double Width { get; }
    }
}
