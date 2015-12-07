using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net6investigations
{
	class Program
	{
		private static List<MyPoint> points;

		static void Main(string[] args)
		{
			points = new List<MyPoint>();

			var p = new MyPoint(5, 6);
			MyPoint q = null;


			AddPoint(p);

			AddPoint(q);


			Console.WriteLine(p.ToString());
			Console.WriteLine(p.Distance);

			Console.ReadKey();
		}


		public static void AddPoint(MyPoint myPoint)
		{
			if (myPoint == null)
			{
				throw new ArgumentNullException(nameof(myPoint));
			}

			points.Add(myPoint);
		}
	}
}
