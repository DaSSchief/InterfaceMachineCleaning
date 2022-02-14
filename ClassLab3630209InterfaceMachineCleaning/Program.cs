using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/// <summary>
/// TASK 3630226
/// You'll write the code in Main which will be executed once a month to assure that the cleaning of all machines is done.
///   For each machine in the shop,
///      If the machine is self-cleanable 
///         call the machine's method to start the cleaning.
///      If the machine is not self-cleanable the 
///         call the Maintenance static class method AddCleaningRequest(), passing the machine.
/// 
/// The three machine types that provide self-cleaning are Turret and Duplicating lathes and the Vertical milling machine.
/// Use an interface to assure self-cleaning machines have the following members
///   A method to start the cleaning process. 
///      In each class, this method should simply write to the console, "Self-cleaning started for machineId" where machineId is the value of the Id property of this machine.
///   A property that contains a percentage, indicating how much of the cleaning process has been completed. 
///      (You won't be writing any code to set/update this property in this lab.)
/// 
/// Task 3630211
///   As a developer, I want to use the same methods on any self-cleaning machine I work with.
/// </summary>


namespace ClassLab3630209InterfaceMachineCleaning
{
   class Program
   {
      public static List<Machine> ShopFloorMachines { get; set; } = new List<Machine>
        {
            new Duplicating {Id="A01", IsOperational = true},
            new Turret {Id="A02", IsOperational = true},
            new Vertical {Id="A03", IsOperational = true},
            new ScrewCutting {Id="A04", IsOperational = true},
            new Duplicating {Id="B01", IsOperational = true},
            new KneeAndColumn {Id="B02", IsOperational = true},
            new Turret {Id="C01", IsOperational = true},
            new KneeAndColumn {Id="C02", IsOperational = true},
            new ScrewCutting {Id="C03", IsOperational = true},
            new Turret {Id="D01", IsOperational = true},
            new Vertical {Id="D02", IsOperational = true},
            new Duplicating {Id="E01", IsOperational = true},
        };
      public static object Item1 { get; private set; }

      public static void Main(string[] args)
      {
         foreach (var machine in ShopFloorMachines)
         {
            if (machine is Duplicating)
            {
               var callDuplicating = new Duplicating();
            }
            else if (machine is Turret)
            {
               var callTurret = new Turret();
            }
            else if (machine is Vertical)
            {
               var callVertical = new Vertical();
            }
            else Maintenance.AddCleaningRequest(machine);

            Console.WriteLine($"Machine ID is {machine.Id} and Machine is Operable is {machine.IsOperational}");

            Console.WriteLine();
         }
      }
   }
}
