using System;

namespace Task3.Logic
{
    public class Calculations
    {


        /// <summary>
        /// Calculate root of the number
        /// </summary>
        /// <param name="source">Source number</param>
        /// <param name="power">Root power</param>
        /// <param name="precision">Acceptable precision</param>
        /// <returns>Root of the source with acceptable precision</returns>
        public static double SqrtNewton(double source, double power, double precision)
        {
            if (power < 0)
                throw new ArgumentOutOfRangeException();

            if (power == 0)
                return double.PositiveInfinity;

            if (power == 1)
                return source;

            double currentApprox, currentApproxPrev;

            currentApprox = source / 2;

            do
            {
                currentApproxPrev = currentApprox;
                currentApprox = ((power - 1) * currentApprox + (source / Math.Pow(currentApprox, power - 1))) / power;
            } while (Math.Abs(currentApproxPrev - currentApprox) > precision);

            return currentApprox;
        }
    }
}
