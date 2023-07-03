using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using SEDC.PizzaApp.Models.Enums;
using SEDC.PizzaApp.Models.viewModel;

namespace SEDC.PizzaApp.Models.viewModel
{
    public class OrderViewModel
    {
		public int Id { get; set; }

        [Display(Name = "Pizza Name")]
        public string PizzaName { get; set; }

        [Display(Name = "User")]
        public string UserId { get; set; }

        [Display(Name = "Is Order Delivered")]
        public bool Delivered { get; set; }

        [Display(Name = "Payment Method")]
        public PaymantMethod PaymentMethod { get; set; }
	}
}

