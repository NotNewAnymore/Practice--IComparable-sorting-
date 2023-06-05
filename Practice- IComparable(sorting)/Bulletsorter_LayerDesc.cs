using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practice__IComparable_sorting_
{
	internal class Bulletsorter_LayerDesc : IComparer<Bullet>
	{
		public int Compare(Bullet? x, Bullet? y)
		{
			if(x.layer > y.layer) return -1;
			else if(x.layer < y.layer) return 1;
			return 0;
		}
	}
}
