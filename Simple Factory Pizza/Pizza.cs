using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory_Pizza
{
    abstract class Pizza
    {
        public virtual void prepare()
        {
            Console.WriteLine("Preparing pizza!");
        }
        public virtual void bake()
        {
            Console.WriteLine("Baking pizza!");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cutting pizza!");
        }
        public virtual void box()
        {
            Console.WriteLine("Boxing pizza!");
        }
    }
}
