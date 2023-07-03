using System;
using System.ComponentModel.DataAnnotations;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.viewModel
{
	public class PizzaViewModel
	{
        public int Id { get; set; }

        [Display(Name = "Pizza Name")]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool IsOnPromotion { get; set; }

        public PizzaSize PizzaSize { get; set; }

        public bool HasExtra { get; set; }

    }
}

