using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace ClassLab3630209InterfaceMachineCleaning
{
    abstract class Lathe : Machine
    {
      public int Speed { get; set; }

        public void Cut()
        {
            Console.WriteLine("Cutting material");
        }
        public void knurl()
        {
            Console.WriteLine("Knurling material");
        }
        public void Drill()
        {
            Console.WriteLine("Drilling material");
        }
    }
}
