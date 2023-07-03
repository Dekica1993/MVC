using System;
using System.ComponentModel.DataAnnotations;
using SEDC.PizzaApp.Models.Enums;
using SEDC.PizzaApp.Models.viewModel;

namespace SEDC.PizzaApp.Models.viewModel
{
	public class OrderDetailsViewModel
	{
		public int Id { get; set; }

		[Display(Name = "Pizza Name")]
		public string PizzaName { get; set; }

        
        public string UserFullName { get; set; }

		public int Price { get; set; }

		public PaymantMethod PaymantMethod { get; set; }

		public bool IsDelivered { get; set; } 
	}
}

