using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLab3630209InterfaceMachineCleaning
{
   class Maintenance
   {
      protected ICleanable _messageDisplay;
      
      public Maintenance(ICleanable messageDisplay)
      {
         _messageDisplay = messageDisplay;
      }

      private static List<Machine> _machinesToClean = new List<Machine>();
      public static void AddCleaningRequest(Machine machine)
      {
         _machinesToClean.Add(machine);
         _messageDisplay.MachineCleaned("Machine needs manual cleaning");

      }
      public void SelfCleaningMessage()
      {
         Console.WriteLine("In maintenance, machine is self-cleaning");
         _messageDisplay.MachineCleaned("Machine was self-cleaned");
      }
   }


}