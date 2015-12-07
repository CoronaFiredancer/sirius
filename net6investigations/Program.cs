using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net6investigations
{
	class Program
	{
		static void Main(string[] args)
		{
			var p = new MyPoint(5 ,6);

			Console.WriteLine(p.ToString());
			Console.WriteLine(p.Distance);

			Console.ReadKey();
		}
	}
}
