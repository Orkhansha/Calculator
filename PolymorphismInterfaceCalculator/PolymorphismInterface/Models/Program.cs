using System;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.Calculate(10,2);
                 Console.WriteLine();
        }
    }
}
