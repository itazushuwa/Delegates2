using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Delegates
    {
        delegate double Operations(double x);

        private Operations[] array = { Add, Substract, Multiply, Divide };

        public void GoThroughtArray(double x)
        {
            foreach (Operations op in array)
            {
                Console.WriteLine(op(x));
            }
        }
        static double Divide(double x) => x / x;
        static double Multiply(double x) => Math.Round(x * x, 5);
        static double Add(double x) => Math.Round(x + x, 5);
        static double Substract(double x) => x - x;
    }
}