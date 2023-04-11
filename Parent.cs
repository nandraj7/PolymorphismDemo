using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Parent
    {
        public void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }

        public virtual void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }

        public virtual void PutData()
        {
            Console.WriteLine("Parent Class PutData Method");
        }
    }
}
