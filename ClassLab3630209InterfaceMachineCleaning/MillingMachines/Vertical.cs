using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLab3630209InterfaceMachineCleaning
{
    class Vertical : MillingMachine, ICleanable
    {
      bool iAmSelfCleaning = true;
      public decimal CleaningProcessCompleted { get; set; }

      public void MachineCleaned(string message)
      {
         Console.WriteLine($"Self-cleaning started for machine...");
      }
      public void SetSpindleColumnAngle(double angleInDegrees)
      {
         Console.WriteLine($"Spindle column set to angle {angleInDegrees}");
      }

      public void SetSpindleVerticalLocation(double heightInInches)
        {
            Console.WriteLine($"Spindle vertical locaion: {heightInInches} inches");

        }
    }
}
