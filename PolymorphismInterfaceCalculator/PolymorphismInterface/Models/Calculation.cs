using PolymorphismInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismInterface
{
    public class Calculation : ICalculate
    {
        public void Calculate(int num1, int num2)
        {
            

            int sum = 0;
            int div = 0;
            int mult = 0;
            int subt = 0;

            sum = num1 + num2;
            subt = num1 - num2;
            div = num1 / num2;
            mult = num1 * num2;

            Console.WriteLine("cem ="+sum);
            Console.WriteLine("ferq ="+subt);
            Console.WriteLine("hasil ="+mult);
            Console.WriteLine("qismet ="+div);
        }

        public void Calculate()
        {
            Console.WriteLine();
        }
    }

}
