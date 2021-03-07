using System;
using System.Collections.Generic;
using System.Linq;
using Rectangle.Impl;

namespace Rectangle.Console
{
	class Program
	{
		/// <summary>
		/// Use this method for local debugging only. The implementation should remain in Rectangle.Impl project.
		/// See TODO.txt file for task details.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			//new Point(-3, 1), new Point(2, 0), new Point(-3, 2),new Point(0, 3)
			List<Point> points = new List<Point>() { new Point(-3, 1), new Point(2, 0), new Point(-3, 2), new Point(0, 3) };//new Point(3,5),new Point (1,1),new Point(4,4) };
			var rectangle = Service.FindRectangle( points);
            if (rectangle == null) System.Console.WriteLine("Uncorrect input data");
			else System.Console.WriteLine( rectangle.ToString());
			System.Console.ReadKey();
		}
	}
}
