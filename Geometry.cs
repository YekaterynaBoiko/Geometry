using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }
        public static Vector Add(Vector vector1, Vector vector2)
        {
            return new Vector
            {
               X = vector1.X + vector2.X,
               Y = vector1.Y + vector2.Y
            };
            
        }


        public static double GetLength(Segment segment)
        {
            double segmentX = segment.End.X - segment.Begin.X;
            double segmentY = segment.End.Y - segment.Begin.Y;
            return Math.Sqrt(segmentX * segmentX + segmentY * segmentY);
        }

        public static bool IsVectorSegment(Vector v, Segment s)
        {
            double length = GetLength(s);
            double lengthBegin = Math.Sqrt(Math.Pow(v.X - s.Begin.X, 2) + Math.Pow(v.Y - s.Begin.Y, 2));
            double lengthEnd = Math.Sqrt(Math.Pow(v.X - s.End.X, 2) + Math.Pow(v.Y - s.End.Y, 2));
            double sumOfLegth = lengthBegin + lengthEnd;

            return Math.Abs((lengthBegin + lengthEnd) - length) < 1e-8;
        }
    }
}
