using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public sealed class SealedParent
    {
        public int Id { get; set; }
        public string Key { get; set; }

        public SealedParent()
        {
            this.Id = 1;
            this.Key = "abcd";
        }

        public void Show()
        {
            Console.WriteLine(this.Id);
            Console.WriteLine(this.Key);
          
        }
    }
}
