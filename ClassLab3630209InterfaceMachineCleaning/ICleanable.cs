using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab3630209InterfaceMachineCleaning
{
   interface ICleanable
   {
      decimal CleaningProcessCompleted { get; set; }

      void MachineCleaned(string message);
      
   }
}
