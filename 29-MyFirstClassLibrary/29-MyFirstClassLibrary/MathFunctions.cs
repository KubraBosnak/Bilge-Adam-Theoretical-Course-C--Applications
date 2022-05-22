using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_MyFirstClassLibrary.StringOperations
{
    public class MathFunctions
    {
        public int Sum(params int[] numbers)
        {
            int result = 0;

            foreach (int item in numbers)
            {
                result += item;
            }

            return result;

        }
    }
}
