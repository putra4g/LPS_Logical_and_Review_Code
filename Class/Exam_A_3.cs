using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_Logical_and_Review_Code
{
	class Laptop
	{
		//public string Os { get; set; } // can not be modified
		public string Os { get; } // can not be modified
		public Laptop(string os)
		{
				Os = os;
		}
		
	}
}
