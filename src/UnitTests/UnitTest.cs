using AreaCalculation;
using NUnit.Framework;
using System;

namespace UnitTests
{
	public class Tests
	{
		[Test]
		public void PifagorTriangleAreaIsSix()
		{
			var pifagorTriangle = new Triangle(3, 4, 5);


			var area = pifagorTriangle.GetArea();

			Assert.True(Math.Abs(area - 6) <= 0);
		}

		[Test]
		public void TriangleValidationFail()
		{
			//не правильный треугольник
			var pifagorTriangle = new Triangle(10, 4, 5);

			//Выкидывает ошибку
			Assert.Catch(() => pifagorTriangle.GetArea());

		}

		[Test]
		public void CircleAreaCalculate()
		{
			var circl = new Circle(10);

			var area = circl.GetArea();
			Assert.True(Math.Abs(area - 100 * Math.PI) <= 0.001);

		}


		[Test]
		public void PifagorTriangleIsRight()
		{
			var pifagorTriangle = new Triangle(3, 4, 5);

			Assert.True(pifagorTriangle.IsRightTriangle());
		}
	}
}