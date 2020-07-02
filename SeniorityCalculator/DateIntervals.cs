using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorityCalculator
{
	class DateInterval : IComparable
	{
		public DateTime start;
		public DateTime end;
		public int CompareTo(object obj)
		{
			DateInterval inter = obj as DateInterval;
			if (start > inter.start)
			{
				return 1;
			}
			else if (start == inter.start)
			{
				return 0;
			}
			else
			{
				return -1;
			}
		}
	}
}
