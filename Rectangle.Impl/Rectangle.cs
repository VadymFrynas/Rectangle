using System;

namespace Rectangle.Impl
{
	public sealed class Rectangle
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public override string ToString() 
		{
			return $"Vertice of rectangle x:{X}, y:{Y}\nHeight: {Height}, Width: {Width}";
		}
	}
}
