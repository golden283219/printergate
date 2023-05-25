using System;
using System.Collections.Generic;
using System.Linq;

namespace PrinterGateXP
{
	
	internal static class ArrayUtils
	{
	
		public static bool FindIntersection(List<string> op1, List<string> op2)
		{
			return op1.AsQueryable<string>().Intersect(op2).Count<string>() != 0;
		}
	}
}
