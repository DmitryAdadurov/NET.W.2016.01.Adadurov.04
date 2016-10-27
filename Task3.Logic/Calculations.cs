using System;

namespace Task3.Logic
{
    public class Calculations
    {
        public static double SqrtNewton(double source, double power, double precision)
        {
            if ((power == null) || (source == null) || (precision == null))
                throw new ArgumentNullException();

            if (power < 0)
                throw new ArgumentOutOfRangeException();

            if (power == 0)
                return double.PositiveInfinity;

            if (power == 1)
                return source;

            if (precision == null)
                throw new ArgumentNullException();

            double currentApprox, currentApproxPrev;

            currentApprox = source / 2;

            //while (true)
            //{
            //    double f = currentApprox * currentApprox - source;

            //    if (Math.Abs(f) < precision)
            //        break;

            //    double dx = -f / (power * currentApprox);
            //    currentApprox += dx;
            //}


            do
            {
                currentApproxPrev = currentApprox;
                currentApprox = ((power - 1) * currentApprox + (source / Math.Pow(currentApprox, power - 1))) / power;
            } while (Math.Abs(currentApproxPrev - currentApprox) > precision);

            return currentApprox;
        }
    }
}
