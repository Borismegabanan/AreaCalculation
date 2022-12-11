using System.ComponentModel.DataAnnotations;

namespace AreaCalculation.Classes.Abstracts
{
	/// <summary>
	/// Интерфейс описания фигуры
	/// </summary>
	public abstract class Figure
	{
		/// <summary>
		/// Правильная ли это фигура.
		/// </summary>
		/// <returns></returns>
		public abstract bool IsValid();

		/// <summary>
		/// Возвращает площадь фигуры.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="ValidationException">Возвращает в случае ошибки валидации фигуры.</exception>
		public virtual double GetArea()
		{
			if (!IsValid())
			{
				throw new ValidationException("Заданная фигура не может существовать");
			}

			return CalculateArea();
		}

		/// <summary>
		/// Возвращает периметр фигуры.
		/// </summary>
		/// <returns></returns>
		public virtual double GetPerimeter()
		{
			if (!IsValid())
			{
				throw new ValidationException("Заданная фигура не может существовать");
			}

			return CalculatePerimeter();
		}

		/// <summary>
		/// Метод вычисления площади фигуры.
		/// </summary>
		/// <returns></returns>
		protected abstract double CalculateArea();

		/// <summary>
		/// Метод вычисления периметра фигуры.
		/// </summary>
		/// <returns></returns>
		protected abstract double CalculatePerimeter();
	}
}
