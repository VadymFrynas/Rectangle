using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle.Impl
{
	public static class Service
	{
		/// <summary>
		/// See TODO.txt file for task details.
		/// Do not change contracts: input and output arguments, method name and access modifiers
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		private static int CorrectPointsCheck(int index, List<Point> points) 
		{
			bool CheckX = false, CheckY = false;
            for (int i = 0; i < points.Count; i++)
            {
				if (i != index) 
				{
					if (CheckX && points[index].Y < points[i].Y) CheckY = true;
					else if (CheckY && points[index].Y < points[i].Y) CheckX = true;
					else if (points[index].X == points[i].X) CheckX = true;
					else if (points[index].Y == points[i].Y) CheckY = true;
				}
            }
			if (CheckY && CheckX) 
			{
				List<double> Distance = new List<double>();
				foreach (var item in points) Distance.Add(Math.Sqrt(Math.Pow(points[index].X-item.X, 2) + Math.Pow(points[index].Y-item.Y, 2)));
				var MaxDistance = Distance.Max(distance => distance);
				//Console.WriteLine(MaxDistance);
				return Distance.IndexOf(MaxDistance);

			}
			else return -1;
		}
		private static bool CheckInput(List<Point> points)
		{
			bool Check = true;
			if (points == null || points.Count < 2) Check = false;
            for (int i = 0; i < points.Count-1; i++)
            {
				if (points[i].X == points[i + 1].X && points[i].Y == points[i + 1].Y) Check = false;
            }
			return Check;
		}
		private static int FindDistance(List<Point> points) 
		{
			List<double> Distance = new List<double>();
			foreach (var item in points) Distance.Add(Math.Sqrt(Math.Pow(item.X, 2) + Math.Pow(item.Y, 2)));
			var MaxDistance = Distance.Max(distance =>distance);
			return Distance.IndexOf(MaxDistance);
		}
		
		public static Rectangle FindRectangle(List<Point> points)
		{
			if (CheckInput(points))
			{
				int Index = FindDistance(points);
				if (CorrectPointsCheck(Index, points) != -1)
				{
					Index = CorrectPointsCheck(Index, points);
				}
				points.RemoveAt(Index);
				Rectangle rectangle = new Rectangle();
				var MaxX = points.Max(x => x.X);
				var MinX = points.Min(x => x.X);
				var MaxY = points.Max(y => y.Y);
				var MinY = points.Min(y => y.Y);
				rectangle.X = MinX;
				rectangle.Y = MinY;
				if (MinY == MaxY) rectangle.Height = MaxY - MinY + 1;
				else rectangle.Height = MaxY - MinY;
				if (MinX == MaxX) rectangle.Width = MaxX - MinX + 1;
				else rectangle.Width = MaxX - MinX;
				return rectangle;
			}
			else return null;
		}
	}
}
