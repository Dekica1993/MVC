using System;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.View
{
	public class OrderViewModel
	{
		public string PizzaName { get; set; }

		public string UserFullName { get; set; }

		public int Price { get; set; }

		public PaymantMethod PaymantMethod { get; set; }
	}
}

