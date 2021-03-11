using System;

namespace Projects
{
    public static class Variables
    {
        public static int GetDecision(int A, int B)
        {
            if ((B - A) != 0)
            {
                return (5 * A + B * B) / (B - A);
            }

            throw new Exception("A = B");
        }

        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static (double division, double divisionReminder) GetDivision(double a, double b)
        {
            if (b != 0)
            {
                double division = a / b;
                double devisionReminder = a % b;

                return (division, devisionReminder);
            }

            throw new Exception();
        }

        public static double GetEquationResult(double a, double b, double c)
        {
            if (a != 0)
            {
                return (c - b) / a;
            }

            throw new Exception();
        }

        public static (double a,double b ) GetEquationOfLine(double x1, double x2, double y1, double y2)
        {
            if ((x1 - x2) != 0)
            {
                double a = (y1 - y2) / (x1 - x2);
                double b = y2 - a * x2;

                return (a, b);
            }

            throw new ArgumentException();
        }
    }
}
