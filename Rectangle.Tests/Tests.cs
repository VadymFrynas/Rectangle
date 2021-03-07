using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Rectangle.Impl;

namespace Rectangle.Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void CheckUncorrectData_LessThan2()
		{
			List<Point> points = new List<Point>() { new Point(4, 4) };

			var rectangle = Service.FindRectangle(points);
			Assert.AreEqual(null,rectangle);
		}
		[Test]
		public void CheckUncorrectData_IsNull()
		{
			List<Point> points = new List<Point>() { null};

			var rectangle = Service.FindRectangle(points);
			Assert.IsNull (rectangle);
		}
		[Test]
		public void CheckUncorrectData_SimilarPoints()
		{
			List<Point> points = new List<Point>() { new Point(4, 4),new Point(4,4) };

			var rectangle = Service.FindRectangle(points);
			Assert.AreEqual(null, rectangle);
		}
		[Test]
		public void TestTwoPoints()
		{
			List<Point> points = new List<Point>() { new Point(4, 4),new Point(1,1) };

			Rectangle.Impl.Rectangle expected = new Rectangle.Impl.Rectangle();
			expected.X = 1;
			expected.Y = 1;
			expected.Width = 1;
			expected.Height = 1;
			
			var rectangle = Service.FindRectangle(points);
			Assert.AreEqual(expected.ToString(), rectangle.ToString());
		}
		[Test]
		public void Test_CorrectPointsCheck1()
		{
			List<Point> points = new List<Point>() { new Point(3, 5), new Point(1, 1), new Point(4, 4) };

			Rectangle.Impl.Rectangle expected = new Rectangle.Impl.Rectangle();
			expected.X = 1;
			expected.Y = 1;
			expected.Width = 3;
			expected.Height = 3;

			var rectangle = Service.FindRectangle(points);
			Assert.AreEqual(expected.ToString(), rectangle.ToString());
		}
		[Test]
		public void Test_CorrectPointsCheck2()
		{
			List<Point> points = new List<Point>() { new Point(-3, 1), new Point(2, 0), new Point(-3, 2),new Point(0,3) };

			Rectangle.Impl.Rectangle expected = new Rectangle.Impl.Rectangle();
			expected.X = -3;
			expected.Y = 1;
			expected.Width = 3;
			expected.Height = 2;

			var rectangle = Service.FindRectangle(points);
			Assert.AreEqual(expected.ToString(), rectangle.ToString());
		}

	}
}