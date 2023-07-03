using System;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.View
{
	public class PizzaViewModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int Price { get; set; }

		public PizzaSize PizzaSize { get; set; }
	}
}

