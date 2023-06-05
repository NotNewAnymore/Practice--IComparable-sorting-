using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__IComparable_sorting_
{
	internal class BulletSorterSoPosAsc : IComparer<Bullet>
	{
		public int Compare(Bullet? x, Bullet? y)
		{
			float xspos = x.xpos + x.ypos;
			float yspos = y.ypos + y.ypos;
			if (xspos > yspos) return 1;
			else if (xspos < yspos) return -1;
			return 0;
		}
	}
}
