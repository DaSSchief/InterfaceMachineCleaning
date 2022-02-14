using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLab3630209InterfaceMachineCleaning
{
    class KneeAndColumn : MillingMachine
    {
      public bool iAmSelfCleaning = false;
      public int KneeLocation { get; set; }
        public int SaddleLocation { get; set; }
    }
}
