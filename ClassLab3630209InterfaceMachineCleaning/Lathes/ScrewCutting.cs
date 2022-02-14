using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLab3630209InterfaceMachineCleaning
{
    class ScrewCutting : Lathe
    {
      public bool iAmSelfCleaning = false;
      public int ThreadsPerInch { get; set; }
      public double Length { get; set; }
    }
}
