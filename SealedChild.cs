using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class SealedChild 
    {
        public void Display()
        {
            SealedParent sealedParent = new SealedParent();
            sealedParent.Show();
        }
    }
}
