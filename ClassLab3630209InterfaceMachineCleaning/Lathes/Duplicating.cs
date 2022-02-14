using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab3630209InterfaceMachineCleaning
{
   class Duplicating : Lathe, ICleanable
   {
      public bool iAmSelfCleaning = true;
      public decimal CleaningProcessCompleted { get; set; }

      public void MachineCleaned(string message)
      {
         Console.WriteLine($"Self-cleaning started for machine");
      }
      public void SetTracerTemplate(string template)
      {
         Console.WriteLine("Tracer template: {template}");
      }
   }
}
