using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__IComparable_sorting_
{
	internal class Bullet : IComparable<Bullet>
	{
		public float xpos;
		public float ypos;
		public int layer;

		public Bullet(int layer,float xpos = 0, float ypos = 0)
		{
			this.xpos = xpos;
			this.ypos = ypos;
			this.layer = layer;
		}
		
		public int CompareTo(Bullet? other)
		{
			if (other.layer > layer) return -1;
			else if (other.layer < layer) return 1;
			else return 0;
		}
	}
}
