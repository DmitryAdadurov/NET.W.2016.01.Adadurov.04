using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Logic
{
    public static class Extensions
    {

        /// <summary>
        /// Represents double as binary string
        /// </summary>
        /// <param name="number">Value to convert</param>
        /// <returns>String with binary representation</returns>
        public static string ToBinaryString(this double number)
        {
            byte[] bytes = BitConverter.GetBytes(number).Reverse().ToArray();
            string result = "";

            foreach (var item in bytes)
            {
                result += Convert.ToString(item, 2).PadLeft(8,'0');
            }
            return result;
        }
    }
}
