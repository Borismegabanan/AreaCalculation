using System;
using AreaCalculation;

namespace MathLibTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//var circl = new Circle(-25);

			//Console.WriteLine($"Radius={circl.R}, Area={circl.GetArea()}");


			var trian = new Triangle(4, 5, 2);

			Console.WriteLine($"Sides={trian.SideA},{trian.SideB},{trian.SideC} \r\nArea={trian.GetArea()}");
		}
	}
}
