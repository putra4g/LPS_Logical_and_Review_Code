using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_Logical_and_Review_Code
{
	class Sum
	{
		//public double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
		//{
		//	double sum = double.NaN;
		//	if (setsOfNumbers != null)
		//	{
		//		if (setsOfNumbers[indexOfSetToSum] != null)
		//		{
		//			sum = setsOfNumbers[indexOfSetToSum].Sum();
		//		}
		//	}
		//	return sum;
		//}

		//use NULL coalescing operators instead off if statement
		public double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
		{
			return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
		}
	}



}
