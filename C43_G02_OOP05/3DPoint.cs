using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_OOP05
{
    internal class _3DPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public static bool operator ==(_3DPoint p1, _3DPoint p2)
        {
            if (ReferenceEquals(p1, p2))
                return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(_3DPoint p1, _3DPoint p2)
        {
            if (p1.X > p2.X)
                return true;
            else if (p1.X == p2.X)
            {
                if (p1.Y > p2.Y)
                    return true;
                else if (p1.Y == p2.Y)
                {
                    if (p1.Z > p2.Z)
                        return true;
                }
            }
            return false;
        }

        public static bool operator <(_3DPoint p1, _3DPoint p2)
        {
            if (p1.X < p2.X)
                return true;
            else if (p1.X == p2.X)
            {
                if (p1.Y < p2.Y)
                    return true;
                else if (p1.Y == p2.Y)
                {
                    if (p1.Z < p2.Z)
                        return true;
                }
            }
            return false;
        }
    }
}

