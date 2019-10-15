using System;

namespace Find_Newtons_Root
{
    public class Program
    {
        /// <summary>
        /// Метод возводит число в заданную степень.
        /// </summary>
        /// <param name="number">Число.</param>
        /// <param name="pow">Степень.</param>
        /// <returns>Число возведенное в степень.</returns>
        static double Pow(double number, double pow)
        {
            if (pow < 0)
                throw new ArgumentException("Степень должен быть положительным.");
            double result = 1;
            for (int i = 0; i < pow; i++) result *= number;
            return result;
        }

        /// <summary>
        /// Метод  возвращает абсолютное значение числа.
        /// </summary>
        /// <param name="number">Число.</param>
        /// <returns>Обсолютное значение.</returns>
        static double Abs(double number)
        {
            if (number < 0) number = -number; 
            return number;
        }

        /// <summary>
        /// Метод  возвращает абсолютное значение числа.
        /// </summary>
        /// <param name="number">Число.</param>
        /// <param name="degree">Число.</param>
        /// <param name="precision">Число.</param>
        /// <returns>Обсолютное значение.</returns>
        public static double FindNthRoot(double number, int degree, double precision)
        {
            if (number <= 0)
                throw new ArgumentException("Невозможно получить корень из отрицательного числа.");
            if (degree <= 0)
                throw new ArgumentException("Корень должен быть положительным.");
            if (precision > 1 || precision < 0)
                throw new ArgumentException("Неправильная точность. Проверьте значения.");

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
