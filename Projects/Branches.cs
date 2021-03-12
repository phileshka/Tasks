using System;

namespace Projects
{
    public static class Branches
    {
        public static int CalculateValue(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        public static int DefineQuarter(int x, int y)
        {
            int result;
            if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x > 0 && y < 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else if (x < 0 && y > 0)
            {
                result = 4;
            }
            else
            {
                result = 0;
            }

            return result;
        }

        public static int[] GetAscansingOrder(int a, int b, int c)
        {
            if (a < b && b < c)
            {
                int min = Math.Min(c, b);
                int max = Math.Max(c, b);

                return new int[] { a, min, max };
            }
            else if (b < a && b < c)
            {
                int min = Math.Min(c, a);
                int max = Math.Max(c, a);

                return new int[] { b, min, max };
            }
            else 
            {
                int min = Math.Min(a, b);
                int max = Math.Max(a, b);

                return new int[] { c, min, max };
            }
        }

        public static double FindD(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        public static double[] FindOneX(double a, double b)
        {
            if (a == 0)
            {
                throw new Exception();
            }
            double x = (-b) / 2 * a;

            return new double[] { x };
        }

        public static double[] FindTwoX(double a, double b, double D)
        {
            if (a == 0)
            {
                throw new Exception("a cannont be equals 0");
            }
            if (D < 0)
            {
                throw new Exception("d cannot be less than 0");
            }
            double x1 = (-b + Math.Sqrt(D) / (2 * a));
            double x2 = (-b - Math.Sqrt(D) / (2 * a));

            return new double[] { x1, x2 };
        }

        public static double[] FindZeroX()
        {
            return new double[0];
        }

        public static double[] GetSquareEquation(double a, double b, double c)
        {
            double D = Branches.FindD(a, b, c);
            if (D > 0)
            {
                return FindTwoX(a, b, D);
            }
            else if (D == 0)
            {
                return FindOneX(a, b);
            }
            else
            {
                return FindZeroX();
            }
        }

        public static string GetNumber(int value)
        {
            string result = string.Empty;
            if (value >= 10 && value <= 19)
            {
                switch (value)
                {
                    case 11:
                        result += "Одинадцать";
                        break;
                    case 12:
                        result += "Двенадцать";
                        break;
                    case 13:
                        result += "Тринадцать";
                        break;
                    case 14:
                        result += "Четырнадцать";
                        break;
                    case 15:
                        result += "Пятнадцать";
                        break;
                    case 16:
                        result += "Шестнадцать";
                        break;
                    case 17:
                        result += "Семнадцать";
                        break;
                    case 18:
                        result += "Восемнадцать";
                        break;
                    case 19:
                        result += "Девятнадцать";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                int tens1 = value / 10;
                int ones1 = value % 10;
                string tens = string.Empty;
                switch (tens1)
                {
                    case 1:
                        tens = "Десять";
                        break;
                    case 2:
                        tens = "Двадцать";
                        break;
                    case 3:
                        tens = "Тридцать";
                        break;
                    case 4:
                        tens = "Сорок";
                        break;
                    case 5:
                        tens = "Пятдесят";
                        break;
                    case 6:
                        tens = "Шестьдесят";
                        break;
                    case 7:
                        tens = "Семьдесят";
                        break;
                    case 8:
                        tens = "Восемьдесят";
                        break;
                    case 9:
                        tens = "Девяносто";
                        break;
                }
                string ones = string.Empty;
                switch (ones1)
                {
                    case 1:
                        ones = "Один";
                        break;
                    case 2:
                        ones = "Два";
                        break;
                    case 3:
                        ones = "Три";
                        break;
                    case 4:
                        ones = "Четыре";
                        break;
                    case 5:
                        ones = "Пять";
                        break;
                    case 6:
                        ones = "Шесть";
                        break;
                    case 7:
                        ones = "Семь";
                        break;
                    case 8:
                        ones = "Восемь";
                        break;
                    case 9:
                        ones = "Девять";
                        break;
                }
                result = $"{tens} {ones}";
            }

            return result;
        }
    }
}
