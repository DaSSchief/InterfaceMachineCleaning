using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLab3630209InterfaceMachineCleaning
{
    class Turret : Lathe, ICleanable

    {
      public bool iAmSelfCleaning = true;
      public decimal CleaningProcessCompleted { get; set; }

      public void MachineCleaned(string message)
      {
         Console.WriteLine($"Self-cleaning started for machine*");
      }
     
      public void SetToolsInTurret()
        {
            Console.WriteLine("Setting Turret Tools");
        }

        public void IndexToolHeads()
        {
            Console.WriteLine("Indexing Tool Heads");
        }
    }
}
