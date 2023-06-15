using System;
using Delegates;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegates del = new Delegates();
            Console.WriteLine("Введите число типа Double");
            del.GoThroughtArray(double.Parse(Console.ReadLine()));
        }
    }
}