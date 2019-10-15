using System;

namespace Find_Newtons_Root
{
    public class Program
    {
        static double Pow(double number, double pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= number;
            return result;
        }

        static double Abs(double number)
        {
            if (number < 0) number = -number; 
            return number;
        }

        public static double FindNthRoot(double number, int degree, double precision)
        {
            if (number <= 0)
                throw new ArgumentException("Can't get even root from negative number.");
            if (degree <= 0)
                throw new ArgumentException("Wrong root. Root must be positive.");
            if (precision > 1 || precision < 0)
                throw new ArgumentException("Wrong precision. Check the values.");

            double root = number / degree;
            double rn = 1.0 / degree * (((degree - 1) * root) + (number / Pow(root, degree - 1)));
            while (Abs(rn - root) >= precision)
            {
                root = rn;
                rn = 1.0 / degree * (((degree - 1) * root) + (number / Pow(root, degree - 1)));
            }
            return rn;
        }
    }
}
