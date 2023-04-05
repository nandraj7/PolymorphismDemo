using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Child : Parent
    {
        public void Show(int num1)
        {
            Console.WriteLine("Child Class Show Method");
        }
    }
}
