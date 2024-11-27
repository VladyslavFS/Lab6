using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{

    public class Triangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Sides must be positive numbers.");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Triangle inequality violated.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculatePerimeter() => SideA + SideB + SideC;

        public double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public string DetermineType()
        {
            if (SideA == SideB && SideB == SideC)
                return "Equilateral";
            if (SideA == SideB || SideB == SideC || SideA == SideC)
                return "Isosceles";
            if (IsRightAngle())
                return "Right";
            return "Scalene";
        }

        private bool IsRightAngle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-6;
        }
    }

}
