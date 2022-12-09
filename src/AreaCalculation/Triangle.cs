using System;
using System.ComponentModel.DataAnnotations;

namespace AreaCalculation
{
	/// <summary>
	/// Класс представления треугольника.
	/// </summary>
	public class Triangle : Figure
	{
		/// <summary>
		/// Первая сторона треугольника
		/// </summary>
		public double SideA { get; set; }

		/// <summary>
		/// Вторая сторона треугольника
		/// </summary>
		public double SideB { get; set; }

		/// <summary>
		/// Третья сторона треугольника
		/// </summary>
		public double SideC { get; set; }

		public Triangle(double sideA, double sideB, double sideC)
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public override bool IsValid()
		{
			if (!(SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA))
			{
				throw new ValidationException("Треугольник существует только тогда, когда сумма 2ух его сторон больше третьей.");
			}

			return true;
		}

		protected override double CalculateArea()
		{
			//полупериметр
			var p = GetPerimeter() / 2;

			return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
		}

		protected override double CalculatePerimeter() => SideA + SideB + SideC;
	}
}