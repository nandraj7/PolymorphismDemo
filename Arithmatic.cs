using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Arithmatic
    {
        public void Add()
        {
            Console.WriteLine("Method With Zero Arugument");
        }

        public void Add(int num1)
        {
            Console.WriteLine("Method With One Parameter");
        }
        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition Of Two Integer Type Values =" + result);
        }

        public void Add(float num1, float num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition Of Two Float Type Values =" + result);
        }

        public void Add(float num1, int num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition Of One Float And One Integer Type Values =" + result);
        }

        public void Add(int num1, float num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition Of One Integer And One Float Type Values =" + result);
        }

       

    }
}
