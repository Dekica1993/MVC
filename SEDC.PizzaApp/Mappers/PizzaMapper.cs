using System;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.viewModel;

namespace SEDC.PizzaApp.Mappers
{
	public static class PizzaMapper
	{
		public static PizzaViewModel ToPizzaViewModel (this Pizza pizza)
		{
			return new PizzaViewModel
			{
				Id = pizza.Id,
				Name = pizza.Name,
				Price = pizza.Price,
				IsOnPromotion = pizza.IsOnPromotion,
				PizzaSize = pizza.PizzaSize,
				HasExtra = pizza.HasExtra

			};
		}
	}
}

