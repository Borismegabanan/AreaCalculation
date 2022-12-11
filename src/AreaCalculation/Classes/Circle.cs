using AreaCalculation.Classes.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace AreaCalculation
{
	/// <summary>
	/// Класс представления окружности.
	/// </summary>
	public class Circle : Figure
	{
		/// <summary>
		/// Радиус окружности.
		/// </summary>
		public double R { get; set; }

		public Circle(double r)
		{
			R = r;
		}

		/// <summary>
		/// Проверка на валидность.
		/// </summary>
		/// <returns></returns>
		public override bool IsValid()
		{
			if (R <= 0)
			{
				throw new ValidationException("Радиус окружности должен быть положительным числом");
			}

			return true;
		}

		/// <summary>
		/// Высчитывает площадь окружности.
		/// </summary>
		/// <returns></returns>
		protected override double CalculateArea()
		{
			return Math.PI * R * R;
		}

		/// <summary>
		/// Высчитывает периметр окружности.
		/// </summary>
		/// <returns></returns>
		protected override double CalculatePerimeter()
		{
			return Math.PI * 2 * R;
		}
	}
}