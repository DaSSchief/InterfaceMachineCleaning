using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace ClassLab3630209InterfaceMachineCleaning
{
	 abstract class MillingMachine : Machine
	 {
		public bool IsOperational { get; set; }
		  
		private List<string> _cutters;

		public void AddCutter(string cutter)
		{
			_cutters.Add(cutter);
		}
		public void RemoveCutter(string cutter)
		{
			_cutters.Remove(cutter);
		}
	 }
}
