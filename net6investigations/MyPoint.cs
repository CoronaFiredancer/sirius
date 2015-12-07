using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace net6investigations
{
	public class MyPoint
	{
		public int X { get; }
		public int Y { get; }

		public MyPoint(int x, int y)
		{
			X = x;
			Y = y;
		}

		public double Distance => Sqrt(X*X + Y*Y);

		public override string ToString() => $"{X}, {Y}";
	}
}
